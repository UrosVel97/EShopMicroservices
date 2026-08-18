# .NET 10 Upgrade Plan

## Overview

**Target**: Upgrade the complete solution from .NET 8 to .NET 10 LTS.
**Scope**: 2 SDK-style projects and 163 lines of code, with one project reference and one incompatible package identified by assessment.

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single operation.
**Rationale**: Both projects target modern .NET, the dependency graph is shallow, no incompatible APIs were detected, and only one package needs compatibility resolution.

## Tasks

### 01-upgrade-solution: Upgrade all projects to .NET 10

Upgrade `BuildingBlocks.csproj` and `Catalog.API.csproj` together from `net8.0` to `net10.0`. Verify the .NET 10 SDK and repository SDK constraints, then resolve the assessment finding for `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` inline while preserving the existing project reference and application behavior. Research should confirm whether a supported package version is available or whether the development-only package can safely be removed.

**Done when**: The .NET 10 SDK is available, both projects target `net10.0`, all direct packages restore without compatibility or vulnerability warnings, and the solution compiles with zero errors and zero warnings.

---

### 02-solution-validation: Validate the upgraded solution

Validate the atomic upgrade across the complete solution after all project and package changes are applied. Discover and run the affected automated tests, confirm the full solution builds warning-free, and check that no dependency conflicts or upgrade-related issues remain.

**Done when**: The complete solution restores and builds with zero errors and zero warnings, all discovered tests pass, and no unresolved .NET 10 package or dependency conflicts remain.
