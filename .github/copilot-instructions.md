# GitHub Copilot Instructions for RimWorld Mod Project

## Mod Overview and Purpose

This mod, tentatively titled "Cold Desert Nights," aims to enhance the environmental and weather systems in the game RimWorld. By implementing new mechanics for temperature management and weather patterns, the mod creates a more dynamic and immersive gameplay experience. Players will face challenging weather conditions and temperature variations based on specific biome data, enhancing the strategic depth required to survive in harsh environments.

## Key Features and Systems

1. **Dynamic Temperature Management:**
   - Implements a sophisticated system to calculate temperature fluctuations based on sun cycles, seasonal changes, and biome-specific conditions.
   - Features classes such as `BiomeData` to manage temperature calculations and offsets.

2. **Advanced Weather Simulation:**
   - Enhances weather realism by adjusting commonality and impact based on biome and current game conditions.
   - Utilizes classes like `WeatherData` to adapt weather patterns dynamically.

3. **Biome-Specific Adaptations:**
   - Customizable settings for different biomes allow players to experience unique environmental challenges.
   - Integrates systems for ignoring rain limits and adjusting temperature effects based on game conditions.

4. **User Interface Enhancements:**
   - Introduces UI elements like `ListTypeDrawer<T>` for better control and visualization of mod settings.
   - Provides a `SpacerDrawer` to organize and manage mod settings interface.

## Coding Patterns and Conventions

- **Static Classes for Patching:**
  - Use static classes (e.g., `AggregateTemperatureOffsetPatch`, `ChooseNextWeatherPatch`) for harmony patches to modify game functionality without altering the base game code directly.

- **Generic Class Utilization:**
  - `ListTypeDrawer<T>` demonstrates the use of generics to create flexible UI components that can handle different data types efficiently.

- **Encapsulation and Private Methods:**
  - Classes like `BiomeData` encapsulate complex logic within private methods (e.g., `UpdateFunction`) to maintain a clean public interface.

- **Consistent Naming Conventions:**
  - Follow C# naming conventions with PascalCase for classes and methods and camelCase for local variables and parameters.

## XML Integration

- XML integration is assumed to be minimal for this mod since no specific XML summary is provided. However, typical mod interactions with RimWorld may involve defining new game objects or modifying existing ones via XML. Ensure any XML files used follow proper RimWorld mod formatting and naming conventions, and consider referencing them in the code where necessary.

## Harmony Patching

- Utilize Harmony library for method patching to ensure compatibility and safe integration with the existing game code.
- Example patches include modifying temperature effects and weather choices through classes such as `AggregateTemperatureOffsetPatch` and `ChooseNextWeatherPatch`.
- Always ensure patches are reversible and do not conflict with other mods by using Harmony’s patching annotations wisely.

## Suggestions for Copilot

To make the most out of GitHub Copilot, consider these strategies:

1. **Contextual Suggestions:**
   - Provide Copilot with ample comments and method descriptions in the code. This helps generate contextually appropriate suggestions.

2. **Leverage Patterns:**
   - When implementing new features, start with existing patterns from classes like `BiomeData` or `WeatherData` to maintain consistency.

3. **Use of Generics:**
   - When adding new UI components or data structures, consider using generics as shown in `ListTypeDrawer<T>` for maximum flexibility.

4. **Interface Enhancements:**
   - Experiment with Copilot to generate UI layouts for the settings pane by describing the desired components and interactions.

5. **Testing and Safety:**
   - Encourage Copilot to suggest test methods by prompting it with "testing" comments or TODOs, ensuring mod stability and functionality. 

This file outlines the mod's foundational elements and guides you and Copilot in maintaining coding standards, enhancing the mod’s features, and ensuring an engaging RimWorld experience.
