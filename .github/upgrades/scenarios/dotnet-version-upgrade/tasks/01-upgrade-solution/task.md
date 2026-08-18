# 01-upgrade-solution: Upgrade all projects to .NET 10

Upgrade `BuildingBlocks.csproj` and `Catalog.API.csproj` together from `net8.0` to `net10.0`. Verify the .NET 10 SDK and repository SDK constraints, then resolve the assessment finding for `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` inline while preserving the existing project reference and application behavior. Research should confirm whether a supported package version is available or whether the development-only package can safely be removed.

**Done when**: The .NET 10 SDK is available, both projects target `net10.0`, all direct packages restore without compatibility or vulnerability warnings, and the solution compiles with zero errors and zero warnings.

## Research Findings

### Scope Inventory
- **Projects affected**: `BuildingBlocks.csproj` and its dependent `Catalog.API.csproj`.
- **Distinct concerns**: Replace both `TargetFramework` values and remove one unsupported development-time container tooling package.
- **Change signals**: Both projects are SDK-style and have no incompatible APIs. `Catalog.API` has the only package issue; no generated stubs were found.
- **Decomposition**: The two related projects follow the same TFM replacement pattern, and the common breakdown hint requires tier decomposition only for chains of three or more projects. Execute atomically as required by the confirmed strategy.

### Files to Modify
- `src/BuildingBlocks/BuildingBlocks/BuildingBlocks.csproj` — replace `net8.0` with `net10.0`.
- `src/Services/Catalog/Catalog.API/Catalog.API.csproj` — remove the unsupported container tooling package and replace `net8.0` with `net10.0`.

### Package Actions
| Package | Current | Target | Notes |
|---------|---------|--------|-------|
| Mapster | 7.4.0 | 7.4.0 | Assessment reports compatibility with .NET 10. |
| MediatR | 14.2.0 | 14.2.0 | Assessment reports compatibility with .NET 10. |
| Carter | 8.2.1 | 8.2.1 | Assessment reports compatibility with .NET 10. |
| Microsoft.VisualStudio.Azure.Containers.Tools.Targets | 1.23.0 | Remove | No supported .NET 10 version was found; the assessment recommends removal. It is development-time Visual Studio container tooling rather than an application runtime dependency. |

### Dependencies and Decisions
- `Catalog.API` references `BuildingBlocks`; the project reference remains unchanged.
- No `global.json`, `Directory.Build.props`, `Directory.Build.targets`, or `Directory.Packages.props` was found, so target frameworks and package versions are project-local.
- A compatible .NET 10 SDK is installed. Both projects are SDK-style modern .NET projects, so validation uses `dotnet build`.
