# Projects and dependencies analysis

This document provides a comprehensive overview of the projects and their dependencies in the context of upgrading to .NETCoreApp,Version=v10.0.

## Table of Contents

- [Executive Summary](#executive-Summary)
  - [Highlevel Metrics](#highlevel-metrics)
  - [Projects Compatibility](#projects-compatibility)
  - [Package Compatibility](#package-compatibility)
  - [API Compatibility](#api-compatibility)
  - [Binding Redirect Configuration](#binding-redirect-configuration)
- [Aggregate NuGet packages details](#aggregate-nuget-packages-details)
- [Top API Migration Challenges](#top-api-migration-challenges)
  - [Technologies and Features](#technologies-and-features)
  - [Most Frequent API Issues](#most-frequent-api-issues)
- [Projects Relationship Graph](#projects-relationship-graph)
- [Project Details](#project-details)

  - [BuildingBlocks\BuildingBlocks\BuildingBlocks.csproj](#buildingblocksbuildingblocksbuildingblockscsproj)
  - [Services\Catalog\Catalog.API\Catalog.API.csproj](#servicescatalogcatalogapicatalogapicsproj)


## Executive Summary

### Highlevel Metrics

| Metric | Count | Status |
| :--- | :---: | :--- |
| Total Projects | 2 | All require upgrade |
| Total NuGet Packages | 4 | 1 need upgrade |
| Total Code Files | 9 |  |
| Total Code Files with Incidents | 2 |  |
| Total Lines of Code | 163 |  |
| Total Number of Issues | 3 |  |
| Estimated LOC to modify | 0+ | at least 0.0% of codebase |

### Projects Compatibility

| Project | Target Framework | Difficulty | Package Issues | API Issues | Binding Issues | Est. LOC Impact | Description |
| :--- | :---: | :---: | :---: | :---: | :---: | :---: | :--- |
| [BuildingBlocks\BuildingBlocks\BuildingBlocks.csproj](#buildingblocksbuildingblocksbuildingblockscsproj) | net8.0 | 🟢 Low | 0 | 0 | 0 |  | ClassLibrary, Sdk Style = True |
| [Services\Catalog\Catalog.API\Catalog.API.csproj](#servicescatalogcatalogapicatalogapicsproj) | net8.0 | 🟢 Low | 1 | 0 | 0 |  | AspNetCore, Sdk Style = True |

### Package Compatibility

| Status | Count | Percentage |
| :--- | :---: | :---: |
| ✅ Compatible | 3 | 75.0% |
| ⚠️ Incompatible | 1 | 25.0% |
| 🔄 Upgrade Recommended | 0 | 0.0% |
| ***Total NuGet Packages*** | ***4*** | ***100%*** |

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 233 |  |
| ***Total APIs Analyzed*** | ***233*** |  |

## Aggregate NuGet packages details

| Package | Current Version | Suggested Version | Projects | Description |
| :--- | :---: | :---: | :--- | :--- |
| Carter | 8.2.1 |  | [Catalog.API.csproj](#servicescatalogcatalogapicatalogapicsproj) | ✅Compatible |
| Mapster | 7.4.0 |  | [BuildingBlocks.csproj](#buildingblocksbuildingblocksbuildingblockscsproj) | ✅Compatible |
| MediatR | 14.2.0 |  | [BuildingBlocks.csproj](#buildingblocksbuildingblocksbuildingblockscsproj) | ✅Compatible |
| Microsoft.VisualStudio.Azure.Containers.Tools.Targets | 1.23.0 |  | [Catalog.API.csproj](#servicescatalogcatalogapicatalogapicsproj) | ⚠️NuGet package is incompatible |

## Top API Migration Challenges

### Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |

### Most Frequent API Issues

| API | Count | Percentage | Category |
| :--- | :---: | :---: | :--- |

## Projects Relationship Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart LR
    P1["<b>📦&nbsp;BuildingBlocks.csproj</b><br/><small>net8.0</small>"]
    P2["<b>📦&nbsp;Catalog.API.csproj</b><br/><small>net8.0</small>"]
    P2 --> P1
    click P1 "#buildingblocksbuildingblocksbuildingblockscsproj"
    click P2 "#servicescatalogcatalogapicatalogapicsproj"

```

## Project Details

<a id="buildingblocksbuildingblocksbuildingblockscsproj"></a>
### BuildingBlocks\BuildingBlocks\BuildingBlocks.csproj

#### Project Info

- **Current Target Framework:** net8.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** ClassLibrary
- **Dependencies**: 0
- **Dependants**: 1
- **Number of Files**: 4
- **Number of Files with Incidents**: 1
- **Lines of Code**: 55
- **Estimated LOC to modify**: 0+ (at least 0.0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph upstream["Dependants (1)"]
        P2["<b>📦&nbsp;Catalog.API.csproj</b><br/><small>net8.0</small>"]
        click P2 "#servicescatalogcatalogapicatalogapicsproj"
    end
    subgraph current["BuildingBlocks.csproj"]
        MAIN["<b>📦&nbsp;BuildingBlocks.csproj</b><br/><small>net8.0</small>"]
        click MAIN "#buildingblocksbuildingblocksbuildingblockscsproj"
    end
    P2 --> MAIN

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 0 |  |
| ***Total APIs Analyzed*** | ***0*** |  |

<a id="servicescatalogcatalogapicatalogapicsproj"></a>
### Services\Catalog\Catalog.API\Catalog.API.csproj

#### Project Info

- **Current Target Framework:** net8.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** AspNetCore
- **Dependencies**: 1
- **Dependants**: 0
- **Number of Files**: 7
- **Number of Files with Incidents**: 1
- **Lines of Code**: 108
- **Estimated LOC to modify**: 0+ (at least 0.0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["Catalog.API.csproj"]
        MAIN["<b>📦&nbsp;Catalog.API.csproj</b><br/><small>net8.0</small>"]
        click MAIN "#servicescatalogcatalogapicatalogapicsproj"
    end
    subgraph downstream["Dependencies (1"]
        P1["<b>📦&nbsp;BuildingBlocks.csproj</b><br/><small>net8.0</small>"]
        click P1 "#buildingblocksbuildingblocksbuildingblockscsproj"
    end
    MAIN --> P1

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 233 |  |
| ***Total APIs Analyzed*** | ***233*** |  |

