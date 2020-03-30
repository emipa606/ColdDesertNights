# ColdDesertNights

Update of Honey Badgers mod for RimWorld 1.1
https://steamcommunity.com/sharedfiles/filedetails/?id=948483652

[img]https://raw.githubusercontent.com/emipa606/RimWorld-Wrapper/master/Notice.png[/img]

Support-chat:
https://invite.gg/mlie

Non-steam version:
https://github.com/emipa606/ColdDesertNights
	
--- Original Description ---
Provides a way to configure the temperature difference between day and night for each biome - including the function used to determine the speed the temperature rises when the sun comes up, and how quickly it falls when the sun goes down.

Each biome can be configured individually, by default, they will all be normal vanilla RimWorld settings, however, each can have:
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
- Changes to temperatures will take place relatively quickly while unpaused (within the next 60 ticks in game when the temperature cache is refreshed). On the world map, temperature changes should appear in the 'Terrain' tab immediately after updating.
- Changes to weather will occur the next time the game tries to get a new weather (generally at least once per in-game day).

Conflicts: Should be none, but I replace the following methods:
- GenTemperature.OffsetFromSunCycle method.
- GenTemperature.SeasonalShiftAmplitudeAt
- WeatherDecider.ChooseNextWeather
- GameConditionManager.AggregateTemperatureOffset

Source: Included with the mod download, and https://github.com/legendblade/Rimworld-ColdDesertNights
