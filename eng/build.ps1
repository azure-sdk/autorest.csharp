param(
    [string] $BuildNumber,
    [string] $BuildAlphaVersion
)

$ErrorActionPreference = 'Stop'

$root = (Resolve-Path "$PSScriptRoot/..").Path.Replace('\', '/')
Import-Module "$root/eng/Generation.psm1" -Force -DisableNameChecking
Set-ConsoleEncoding

$artifacts = "$root/artifacts"

# try to remove the artifacts folder if it exists
if (Test-Path "$artifacts") {
    Remove-Item -Recurse -Force "$artifacts"
}

$buildAlpha = $BuildAlphaVersion -ieq "true"

if ($BuildNumber) {
    # set package versions
    $versionTag = $buildAlpha ? "-alpha" : "-beta"
    
    $autoRestPackageVersion = node -p -e "require('$root/src/AutoRest.CSharp/package.json').version"
    $autoRestVersion = "$autoRestPackageVersion$versionTag.$BuildNumber"
    Write-Host "Setting output variable 'autorestVersion' to $autoRestVersion"
    Write-Host "##vso[task.setvariable variable=autorestVersion;isoutput=true]$autoRestVersion"

    $emitterPackageVersion = node -p -e "require('$root/src/TypeSpec.Extension/Emitter.Csharp/package.json').version"
    $emitterVersion = "$emitterPackageVersion$versionTag.$BuildNumber"
    Write-Host "Setting output variable 'emitterVersion' to $emitterVersion"
    Write-Host "##vso[task.setvariable variable=emitterVersion;isoutput=true]$emitterVersion"
}

# build the nuget package

$versionOption = $BuildNumber ? "/p:Version=$autoRestVersion" : ""

Write-Host "Working in $root"
Push-Location $root
try
{
    Invoke "dotnet pack src/AutoRest.CSharp/AutoRest.CSharp.csproj $versionOption -o artifacts/packages -warnaserror -c Release" -executePath $PWD
}
finally
{
    Pop-Location
}

# pack the c# npm package
$prefix = "$artifacts/bin/AutoRest.CSharp/Release/net6.0/"
Write-Host "Working in $prefix"
Push-Location $prefix
try {
    if ($BuildNumber) {
        Invoke "npm version --no-git-tag-version $autoRestVersion" -executePath $PWD
    }

    $file = Invoke "npm pack -q" -executePath $PWD

    Write-Host "Copy $file to artifacts/packages"
    Copy-Item $file -Destination "$artifacts/packages"
}
finally
{
    Pop-Location
}


# build and pack the emitter
$prefix = "$root/src/TypeSpec.Extension/Emitter.Csharp"
Write-Host "Working in $prefix"
Push-Location $prefix
try {
    Invoke "npm run build" -executePath $PWD

    if ($BuildNumber) {
        Write-Host "Updating package.json use the new @autorest/csharp version`n"

        $packageFileContent = (Get-Content -Raw "package.json") -replace `
            '"@autorest/csharp": ".*?"',
            "`"@autorest/csharp`": `"$autoRestVersion`""

        Set-Content -Path "$prefix/package.json" -Value $packageFileContent -NoNewline

        # update the emitter version
        Invoke "npm version --no-git-tag-version $emitterVersion" -executePath $PWD
    }

    #pack the emitter
    $file = Invoke "npm pack -q" -executePath $PWD
    Copy-Item $file -Destination "$artifacts/packages"
}
finally
{
    Pop-Location
}
