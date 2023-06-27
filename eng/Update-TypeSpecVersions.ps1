$ErrorActionPreference = 'Stop'

$root = (Resolve-Path "$PSScriptRoot/..").Path.Replace('\', '/')
Import-Module "$root/eng/Generation.psm1" -Force -DisableNameChecking
Set-ConsoleEncoding

$artifacts = "$root/artifacts"
$packageJsonFolder = "$artifacts/package-json"

Push-Location $root
try {
    Write-Host "Deleting package-lock.json file and node_modules folders"
    if (Test-Path "package-lock.json") {
        Remove-Item -Force "package-lock.json"
    }

    if (Test-Path "$packageJsonFolder") {
        Remove-Item -Recurse -Force "$packageJsonFolder"
    }

    if (Test-Path "node_modules") {
        Remove-Item -Recurse -Force "node_modules"
    }

    if (Test-Path "src/TypeSpec.Extension/Emitter.Csharp/node_modules") {
        Remove-Item -Recurse -Force "src/TypeSpec.Extension/Emitter.Csharp/node_modules"
    }

    # update package.json and lock file

    Invoke "npx @azure-tools/typespec-bump-deps@0.2.0 `"$root/package.json`" --add-npm-overrides"
    Invoke "npx @azure-tools/typespec-bump-deps@0.2.0 `"$root/src/TypeSpec.Extension/Emitter.Csharp/package.json`""
    Invoke "npm install"

    # list npm packages after install or ci
    Invoke "npm ls -a"

    Write-Host "Coping package.json files to artifacts/package-json"

    New-Item -ItemType Directory -Path "$packageJsonFolder" | Out-Null
    Copy-Item "package*.json" $packageJsonFolder
    Copy-Item "src/TypeSpec.Extension/Emitter.Csharp/package.json" "$packageJsonFolder/emitter-package.json"
}
finally {
    Pop-Location
}
