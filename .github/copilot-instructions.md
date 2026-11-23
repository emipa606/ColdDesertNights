# GitHub Copilot Instructions for Cold Desert Nights (Continued) RimWorld Mod

## Mod Overview and Purpose
Cold Desert Nights (Continued) is a RimWorld mod that provides a way to configure the temperature difference between day and night for each biome. This includes the function used to determine the speed the temperature rises when the sun comes up, and how quickly it falls when the sun goes down. The mod allows for individual biome configuration with options to change the temperature function, set the temperature difference between night and day, and adjust the temperature offset from normal. Additionally, it allows for configuring weather settings for each biome, such as weather weight, maximum seasonal shift, and temperature limits for weather selection.

## Key Features and Systems
- **Biome Configuration**: Each biome can be configured individually with options to change the temperature function, set the temperature difference between night and day, and adjust the temperature offset from normal.
- **Weather Configuration**: Each biome has options to configure weather settings, including weather weight, maximum seasonal shift, and temperature limits for weather selection.
- **Real-time Temperature Changes**: Changes to temperatures take place relatively quickly while unpaused, with temperature changes appearing in the 'Terrain' tab on the world map immediately after updating.
- **Harmony Patching**: The mod replaces several vanilla methods using Harmony patching, including GenTemperature.OffsetFromSunCycle, GenTemperature.SeasonalShiftAmplitudeAt, WeatherDecider.ChooseNextWeather, and GameConditionManager.AggregateTemperatureOffset.

## Coding Patterns and Conventions
The Cold Desert Nights (Continued) mod follows several coding patterns and conventions that are common in RimWorld modding:

- **Modding Framework**: The mod uses the RimWorld modding framework, which includes the use of Harmony patching and XML integration.
- **XML Integration**: The mod uses XML files to define various mod features and settings.
- **Harmony Patching**: The mod uses Harmony patching to replace vanilla methods with custom implementations.
- **Mod Configuration**: The mod allows for real-time configuration of settings while playing, with changes taking effect immediately.

## XML Integration
The Cold Desert Nights (Continued) mod uses XML files to define various mod features and settings. The mod has an XML file for defining translation templates, which includes options for updating feature definitions.

## Harmony Patching
The Cold Desert Nights (Continued) mod uses Harmony patching to replace several vanilla methods with custom implementations. The mod replaces the following methods:

- **GenTemperature.OffsetFromSunCycle**: This method is used to determine the offset from the sun cycle for calculating temperature.
- **GenTemperature.SeasonalShiftAmplitudeAt**: This method is used to determine the amplitude of seasonal temperature shift at a given location.
- **WeatherDecider.ChooseNextWeather**: This method is used to choose the next weather based on various factors.
- **GameConditionManager.AggregateTemperatureOffset**: This method is used to aggregate temperature offsets from various game conditions.

## Suggestions for Copilot
When working on the Cold Desert Nights (Continued) mod, it is recommended to use GitHub Copilot to assist with coding tasks. Copilot can be particularly useful for generating code snippets and suggestions for implementing features and fixing bugs. Some suggestions for using Copilot in this mod include:

- **XML Integration**: Copilot can assist with generating XML code snippets for defining mod features and settings.
- **Harmony Patching**: Copilot can assist with generating Harmony patch code snippets for replacing vanilla methods with custom implementations.
- **Mod Configuration**: Copilot can assist with generating code snippets for implementing real-time configuration of settings while playing.

By following these guidelines and using GitHub Copilot, developers can efficiently work on the Cold Desert Nights (Continued) mod and add new features and fix bugs.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Temporary files

- Do not create temporary files, build output, test artifacts, or Copilot session
  folders inside the mod root.
- Store temporary artifacts under `%USERPROFILE%\CopilotTemp\[modname]`.
- Direct build and test output there as well, without changing project settings.
- Clean up task-specific temporary artifacts when finished.

## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

