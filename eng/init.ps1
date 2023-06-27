param(
    [string] $PackageJsonArtifacts
)

$ErrorActionPreference = 'Stop'

$root = (Resolve-Path "$PSScriptRoot/..").Path.Replace('\', '/')
Import-Module "$root/eng/Generation.psm1" -Force -DisableNameChecking
Set-ConsoleEncoding


Push-Location $root
try {
    if (Test-Path "$root/node_modules") {
        Remove-Item -Recurse -Force "$root/node_modules"
    }
    
    if (Test-Path "$root/src/TypeSpec.Extension/Emitter.Csharp/node_modules") {
        Remove-Item -Recurse -Force "$root/src/TypeSpec.Extension/Emitter.Csharp/node_modules"
    }

    if ($PackageJsonArtifacts) {
        Copy-Item "$PackageJsonArtifacts/package*.json" $root -Force
        Copy-Item "$PackageJsonArtifacts/emitter-package.json" "$root/src/TypeSpec.Extension/Emitter.Csharp/package.json" -Force
        
        Write-Host "Adding package.json files to git index to avoid diff detection"
        Invoke "git add './package.json' './package-lock.json' './src/TypeSpec.Extension/Emitter.Csharp/package.json'"
    }

    # install and list npm packages
    Invoke "npm ci"
    Invoke "npm ls -a"
}
finally {
    Pop-Location
}
