$ErrorActionPreference = 'Stop'

$root = (Resolve-Path "$PSScriptRoot/..").Path.Replace('\', '/')
Import-Module "$root/eng/Generation.psm1" -Force -DisableNameChecking
Set-ConsoleEncoding

Push-Location $root
try {
    # check if shared code is up to date
    ./eng/SharedCodeCheck.ps1

    # build CADL Ranch Mock Api project
    Push-Location "$root/test/CadlRanchMockApis"
    try {
        Invoke "npm run build" -executePath $PWD
    }
    finally {
        Pop-Location
    }

    # build the nuget package
    Invoke "dotnet test AutoRest.CSharp.sln /bl:artifacts/logs/debug.binlog"

    Invoke "dotnet test AutoRest.CSharp.sln -c Release /bl:artifacts/logs/release.binlog"

    # build and pack the emitter
    Push-Location "$root/src/TypeSpec.Extension/Emitter.Csharp"
    try {
        Invoke "npm run prettier" -executePath $PWD

        Invoke "npm run build" -executePath $PWD
        
        Invoke "npm run test" -executePath $PWD
    }
    finally {
        Pop-Location
    }

    # run E2E Test for TypeSpec emitter
    Write-Host "./eng/ExecuteTypeSpecEmitterUnitTests.ps1"
    ./eng/ExecuteTypeSpecEmitterUnitTests.ps1
}
finally {
    Pop-Location
}
