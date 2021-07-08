# ColdDesertNights

![Image](https://i.imgur.com/WAEzk68.png)

Update of Taryn Winterblades mod
https://steamcommunity.com/sharedfiles/filedetails/?id=948483652

- Added french translation, thanks qux!

![Image](https://i.imgur.com/7Gzt3Rg.png)


[table]
	[tr]
		[td]https://invite.gg/Mlie]![Image](https://i.imgur.com/zdzzBrc.png)
[/td]
		[td]https://github.com/emipa606/ColdDesertNights]![Image](https://i.imgur.com/kTkpTOE.png)
[/td]
	[/tr]
[/table]
	
![Image](https://i.imgur.com/NOW7jU1.png)


**This has been ported to 1.1 by Mlie**: https://steamcommunity.com/sharedfiles/filedetails/?id=2042689053

---------------------------------------------------------------------

Provides a way to configure the temperature difference between day and night for each biome - including the function used to determine the speed the temperature rises when the sun comes up, and how quickly it falls when the sun goes down.

Each biome can be configured individually, [u]by default, they will all be normal vanilla RimWorld settings[/u], however, each can have:
- The temperature function changed between one of three settings: Vanilla, Flatter, Flattest; see the graph and Excel image for more information.
- The temperature difference between night and day set (in degrees Celsius)
- The temperature offset from normal (in degrees Celsius) in case you want to make a biome warmer or colder.
- The max seasonal shift (in degrees Celsius); this is mostly based on the distance from the equator (further north or south will produce higher variances in temperature based on this value as a maximum at one of the poles)
- For each type of weather: 
  - The weight of the weather being chosen
  - If the weather can be chosen multiple times in a row
  - If the weather can be chosen within the first week of gameplay (ie: thunderstorms)
- If multiple rainy weather types can be chosen in a row
- The minimum and maximum temperatures to use for determining which weather to use - want a freezing desert that still gets rain? Set the minimum temperature to 1C and you won&apos;t ever get snow.
- The increase/decrease in temperature caused by the Heat Wave and Cold Snap game conditions.

All settings can be configured while playing:
- Changes to temperatures will take place relatively quickly while unpaused (within the next 60 ticks in game when the temperature cache is refreshed).  On the world map, temperature changes should appear in the &apos;Terrain&apos; tab immediately after updating.
- Changes to weather will occur the next time the game tries to get a new weather (generally at least once per in-game day).

**Conflicts**: Should be none, but I replace the following methods:
- GenTemperature.OffsetFromSunCycle method.
- GenTemperature.SeasonalShiftAmplitudeAt
- WeatherDecider.ChooseNextWeather
- GameConditionManager.AggregateTemperatureOffset


![Image](https://i.imgur.com/Rs6T6cr.png)



-  See if the the error persists if you just have this mod and its requirements active.
-  If not, try adding your other mods until it happens again.
-  Post your error-log using https://steamcommunity.com/workshop/filedetails/?id=818773962]HugsLib and command Ctrl+F12
-  For best support, please use the Discord-channel for error-reporting.
-  Do not report errors by making a discussion-thread, I get no notification of that.
-  If you have the solution for a problem, please post it to the GitHub repository.




