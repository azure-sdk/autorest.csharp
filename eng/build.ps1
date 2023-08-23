param(
    [string] $BuildNumber,
    [string] $BuildAlphaVersion,
    [string] $Output
)

$ErrorActionPreference = 'Stop'

$root = (Resolve-Path "$PSScriptRoot/..").Path.Replace('\', '/')
Import-Module "$root/eng/Generation.psm1" -Force -DisableNameChecking
Set-ConsoleEncoding

[bool]$BuildAlphaVersion = $BuildAlphaVersion -ieq "true"

$artifacts = "$root/artifacts"
$output = $Output ? $Output : "$artifacts/ci-build"

# try to remove the artifacts folder if it exists
if (Test-Path "$artifacts") {
    Remove-Item -Recurse -Force "$artifacts"
}

# try to remove the artifacts folder if it exists
if (Test-Path "$output") {
    Remove-Item -Recurse -Force "$output"
}

if ($UseTypeSpecNext) {
    Write-Host "Using TypeSpec.Next"
    $env:TypeSpecVersion = "next"
}

# create the output folders
New-Item -ItemType Directory -Force -Path "$artifacts" | Out-Null
New-Item -ItemType Directory -Force -Path "$output" | Out-Null

$generatorVersion = node -p -e "require('$root/src/AutoRest.CSharp/package.json').version"
$emitterVersion = node -p -e "require('$root/src/TypeSpec.Extension/Emitter.Csharp/package.json').version"

if ($BuildNumber) {
    # set package versions
    $versionTag = $BuildAlphaVersion ? "-alpha" : "-beta"
    
    $generatorVersion = "$generatorVersion$versionTag.$BuildNumber"
    Write-Host "Setting output variable 'generatorVersion' to $generatorVersion"
    Write-Host "##vso[task.setvariable variable=generatorVersion;isoutput=true]$generatorVersion"

    $emitterVersion = "$emitterVersion$versionTag.$BuildNumber"
    Write-Host "Setting output variable 'emitterVersion' to $emitterVersion"
    Write-Host "##vso[task.setvariable variable=emitterVersion;isoutput=true]$emitterVersion"
}

$packageMatrix | ConvertTo-Json | Set-Content $output/packages.json

# build the nuget package

$versionOption = $BuildNumber ? "/p:Version=$generatorVersion" : ""

Write-Host "Working in $root"
Push-Location $root
try
{
    Invoke "dotnet pack src/AutoRest.CSharp/AutoRest.CSharp.csproj $versionOption -o $output/packages -warnaserror -c Release" -executePath $PWD
}
finally
{
    Pop-Location
}

# pack the c# npm package
Push-Location "$artifacts/bin/AutoRest.CSharp/Release/net6.0/"
try {
    Write-Host "Working in $PWD"
    if ($BuildNumber) {
        Invoke "npm version --no-git-tag-version $generatorVersion" -executePath $PWD
    }

    $file = Invoke "npm pack -q" -executePath $PWD
    Copy-Item $file -Destination "$output/packages"
}
finally
{
    Pop-Location
}

# build and pack the emitter
Push-Location "$root/src/TypeSpec.Extension/Emitter.Csharp"
try {
    Write-Host "Working in $PWD"
    Invoke "npm run build" -executePath $PWD

    if ($BuildNumber) {
        Write-Host "Updating package.json use the new @autorest/csharp version`n"

        $originalContent = Get-Content -Raw "package.json"
        $packageFileContent = $originalContent -replace `
            '"@autorest/csharp": ".*?"',
            "`"@autorest/csharp`": `"$generatorVersion`""

        Set-Content -Path "package.json" -Value $packageFileContent -NoNewline

        # update the emitter version
        Invoke "npm version --no-git-tag-version $emitterVersion" -executePath $PWD
    }

    #pack the emitter
    $file = Invoke "npm pack -q" -executePath $PWD
    Copy-Item $file -Destination "$output/packages"
}
finally
{
    Pop-Location
}

. $root/eng/New-EmitterPackageJson.ps1 -PackageJsonPath "./package.json" -OutputDirectory $output
