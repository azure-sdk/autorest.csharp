param(
    [string] $UseTypeSpecNext
)

$ErrorActionPreference = 'Stop'

$root = (Resolve-Path "$PSScriptRoot/..").Path.Replace('\', '/')
Import-Module "$root/eng/Generation.psm1" -Force -DisableNameChecking
Set-ConsoleEncoding

[bool]$UseTypeSpecNext = $UseTypeSpecNext -ieq "true"

Push-Location $root
try {
    if (Test-Path "$root/node_modules") {
        Remove-Item -Recurse -Force "$root/node_modules"
    }
    
    if (Test-Path "$root/src/TypeSpec.Extension/Emitter.Csharp/node_modules") {
        Remove-Item -Recurse -Force "$root/src/TypeSpec.Extension/Emitter.Csharp/node_modules"
    }

    # if ($PackageJsonArtifacts) {
    #     Copy-Item "$PackageJsonArtifacts/package*.json" $root -Force
    #     Copy-Item "$PackageJsonArtifacts/emitter-package.json" "$root/src/TypeSpec.Extension/Emitter.Csharp/package.json" -Force
        
    #     Write-Host "Adding package.json files to git index to avoid diff detection"
    #     Invoke "git add './package.json' './package-lock.json' './src/TypeSpec.Extension/Emitter.Csharp/package.json'"
    # }

    # install and list npm packages

    if ($UseTypeSpecNext) {
        if (Test-Path "$root/package-lock.json") {
            Remove-Item -Force "$root/package-lock.json"
        }

        Write-Host "Using TypeSpec.Next"
        Invoke "npx -y @azure-tools/typespec-bump-deps@0.3.0 --use-peer-ranges package.json ./src/TypeSpec.Extension/Emitter.Csharp/package.json"
        Invoke "npm install"
    } else {
        Invoke "npm ci"
    }

    Invoke "npm ls -a"

    Write-Host "Adding package.json files to git index to avoid diff detection"
    Invoke "git add ./package.json ./package-lock.json ./src/TypeSpec.Extension/Emitter.Csharp/package.json"
}
finally {
    Pop-Location
}
