## Files Modified
- `src/BuildingBlocks/BuildingBlocks/BuildingBlocks.csproj`
- `src/Services/Catalog/Catalog.API/Catalog.API.csproj`
- `.github/upgrades/scenarios/dotnet-version-upgrade/scenario-instructions.md`
- `.github/upgrades/scenarios/dotnet-version-upgrade/breakdown-context.md`
- `.github/upgrades/scenarios/dotnet-version-upgrade/tasks/01-upgrade-solution/task.md`

## Build Result
- Errors: 0
- Warnings: 0
- Projects built: BuildingBlocks, Catalog.API
- Full solution clean build: succeeded in 5.1 seconds
- Outputs verified under `bin/Debug/net10.0`

## Test Result
- Tests run: 0
- Passed: 0
- Failed: 0
- No test projects are present in the solution; `dotnet test` completed successfully.

## Changes Summary
- Verified that a compatible .NET 10 SDK is installed and that no `global.json` constrains SDK selection.
- Retargeted both SDK-style projects from `net8.0` to `net10.0`.
- Removed `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` 1.23.0 because assessment and package lookup found no .NET 10-supported version; it is development-time tooling rather than an application runtime dependency.
- Preserved compatible package versions and the Catalog.API-to-BuildingBlocks project reference.
- Confirmed restore reports no vulnerable packages from configured sources.

## Done-When Verification
- .NET 10 SDK available: verified by SDK validation tool.
- Both projects target `net10.0`: verified in project files and `net10.0` build outputs.
- Direct packages restore without compatibility or vulnerability warnings: verified by clean restore/build and `dotnet list package --vulnerable --include-transitive`.
- Solution compiles with zero errors and zero warnings: verified by a non-incremental full solution build.

## Issues Encountered
- The Visual Studio container tooling package has no supported .NET 10 version. Resolved inline by removing its project reference; Docker project properties remain intact.
