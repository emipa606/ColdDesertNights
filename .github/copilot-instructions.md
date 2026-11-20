# GitHub Copilot Instructions for Cold Desert Nights (Continued) Mod

## Mod Overview and Purpose

**Mod Name:** Cold Desert Nights (Continued)  
**Mod Description:** This mod provides a way to configure the temperature difference between day and night for each biome in RimWorld. It allows customization of various temperature-related settings, including temperature functions, offsets, and seasonal shifts. Additionally, it enables detailed configuration of weather conditions, including weather weights, consecutive weather types, and minimum/maximum temperatures for weather selection. The mod aims to enhance the realism of temperature fluctuations and weather patterns in the game.

## Key Features and Systems

### Biome Temperature Configuration
- **Temperature Functions:** Users can select from three different temperature functions for each biome: Vanilla, Flatter, and Flattest.
- **Temperature Difference:** Set the difference between day and night temperatures in degrees Celsius.
- **Temperature Offset:** Adjust the overall temperature offset for each biome to make it warmer or colder.
- **Max Seasonal Shift:** Define the maximum seasonal temperature shift based on the distance from the equator.

### Weather Configuration
- **Weather Weights:** Customize the probability of each weather type occurring.
- **Consecutive Weather Types:** Allow or disallow multiple consecutive rainy weather types.
- **Weather in First Week:** Enable or disable specific weather types during the first week of gameplay.
- **Minimum/Maximum Temperatures:** Set temperature limits to influence weather selection (e.g., freezing deserts still getting rain).

### Real-Time Adjustments
- **Dynamic Temperature Changes:** Changes to temperature settings take effect relatively quickly within the game.
- **Weather Updates:** Weather changes occur the next time the game generates new weather conditions.

## Coding Patterns and Conventions

### C# Code Structure
- **Namespaces:** Use clear and descriptive namespaces to organize code logically.
- **Classes and Methods:** Keep classes focused on specific functionalities (e.g., `BiomeData`, `Patches`).
- **Method Naming:** Use meaningful and consistent method names (e.g., `CalculateSeasonalTemp`, `GetBiomeConditionTemperatureOffset`).
- **Documentation:** Add XML documentation comments to methods and classes for clarity.

### XML Integration
- **Def Files:** Utilize XML definition files to store mod-specific data such as translations.
- **Mod Settings:** Store configurable settings in XML to allow user adjustments.

### Harmony Patching
- **Patch Classes:** Create separate classes for Harmony patches (e.g., `GenTemperature_OffsetFromSunCycle`).
- **Prefix/Postfix Methods:** Implement `Prefix` and `Postfix` methods to modify or extend existing game methods.

## XML Integration

### Translation Files
- **TranslationTemplate:** Use XML files for translations, ensuring compatibility with HugsLib and other translation tools.

### Definition Files
- **Mod-Specific Data:** Store mod-specific data in XML files to maintain separation from vanilla game data.

## Harmony Patching

### Patches Overview
- **GenTemperature_OffsetFromSunCycle:** Patch the `OffsetFromSunCycle` method to customize temperature offsets.
- **GenTemperature_SeasonalShiftAmplitudeAt:** Patch the `SeasonalShiftAmplitudeAt` method to adjust seasonal temperature shifts.
- **GameConditionManager_AggregateTemperatureOffset:** Patch the `AggregateTemperatureOffset` method to modify temperature offsets caused by game conditions.
- **WeatherDecider_ChooseNextWeather:** Patch the `ChooseNextWeather` method to customize weather selection.

### Patch Implementation
- **Prefix Methods:** Use `Prefix` methods to replace or modify the original method behavior.
- **Postfix Methods:** Use `Postfix` methods to add additional functionality after the original method executes.

## Suggestions for Copilot

1. **Biome Configuration Management:** When implementing new features related to biome temperature or weather configuration, ensure that the code adheres to existing patterns and conventions.
2. **Translation Updates:** When adding or updating translations, ensure that the XML files are properly formatted and compatible with HugsLib.
3. **Patch Implementation:** When creating new Harmony patches, ensure that they are well-documented and test them thoroughly to avoid conflicts with other mods.
4. **Code Refactoring:** Suggest refactoring existing code to improve readability and maintainability, especially for complex methods or classes.
5. **User Interface Enhancements:** Propose enhancements to the user interface for easier configuration of temperature and weather settings.

By following these guidelines and suggestions, developers can contribute effectively to the Cold Desert Nights (Continued) mod, ensuring high-quality code and a rich user experience.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

