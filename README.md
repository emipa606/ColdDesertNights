# [Cold Desert Nights (Continued)](https://steamcommunity.com/sharedfiles/filedetails/?id=2042689053)

![Image](https://i.imgur.com/buuPQel.png)

Update of Taryn Winterblades mod
https://steamcommunity.com/sharedfiles/filedetails/?id=948483652

- Added french translation, thanks qux!

![Image](https://i.imgur.com/pufA0kM.png)
	
![Image](https://i.imgur.com/Z4GOv8H.png)

**This has been ported to 1.1 by Mlie**: https://steamcommunity.com/sharedfiles/filedetails/?id=2042689053

---------------------------------------------------------------------

Provides a way to configure the temperature difference between day and night for each biome - including the function used to determine the speed the temperature rises when the sun comes up, and how quickly it falls when the sun goes down.

Each biome can be configured individually, <ins>by default, they will all be normal vanilla RimWorld settings</ins>, however, each can have:
- The temperature function changed between one of three settings: Vanilla, Flatter, Flattest; see the graph and Excel image for more information.
- The temperature difference between night and day set (in degrees Celsius)
- The temperature offset from normal (in degrees Celsius) in case you want to make a biome warmer or colder.
- The max seasonal shift (in degrees Celsius); this is mostly based on the distance from the equator (further north or south will produce higher variances in temperature based on this value as a maximum at one of the poles)
- For each type of weather: 
  - The weight of the weather being chosen
  - If the weather can be chosen multiple times in a row
  - If the weather can be chosen within the first week of gameplay (ie: thunderstorms)
- If multiple rainy weather types can be chosen in a row
- The minimum and maximum temperatures to use for determining which weather to use - want a freezing desert that still gets rain? Set the minimum temperature to 1C and you won't ever get snow.
- The increase/decrease in temperature caused by the Heat Wave and Cold Snap game conditions.

All settings can be configured while playing:
- Changes to temperatures will take place relatively quickly while unpaused (within the next 60 ticks in game when the temperature cache is refreshed).  On the world map, temperature changes should appear in the 'Terrain' tab immediately after updating.
- Changes to weather will occur the next time the game tries to get a new weather (generally at least once per in-game day).

**Conflicts**: Should be none, but I replace the following methods:
- GenTemperature.OffsetFromSunCycle method.
- GenTemperature.SeasonalShiftAmplitudeAt
- WeatherDecider.ChooseNextWeather
- GameConditionManager.AggregateTemperatureOffset


![Image](https://i.imgur.com/PwoNOj4.png)



-  See if the the error persists if you just have this mod and its requirements active.
-  If not, try adding your other mods until it happens again.
-  Post your error-log using the [Log Uploader](https://steamcommunity.com/sharedfiles/filedetails/?id=2873415404) or the standalone [Uploader](https://steamcommunity.com/sharedfiles/filedetails/?id=2873415404) and command Ctrl+F12
-  For best support, please use the Discord-channel for error-reporting.
-  Do not report errors by making a discussion-thread, I get no notification of that.
-  If you have the solution for a problem, please post it to the GitHub repository.
-  Use [RimSort](https://github.com/RimSort/RimSort/releases/latest) to sort your mods

 

[![Image](https://img.shields.io/github/v/release/emipa606/ColdDesertNights?label=latest%20version&style=plastic&color=9f1111&labelColor=black)](https://steamcommunity.com/sharedfiles/filedetails/changelog/2042689053) | tags:  biome,  seasons
