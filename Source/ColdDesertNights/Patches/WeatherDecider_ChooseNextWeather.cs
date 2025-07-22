using System;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ColdDesertNights.Patches;

[HarmonyPatch(typeof(WeatherDecider), "ChooseNextWeather")]
// ReSharper disable once UnusedMember.Global
public static class WeatherDecider_ChooseNextWeather
{
    public static bool Prefix(WeatherDecider __instance, ref WeatherDef __result)
    {
        try
        {
            // Get all of our ducks in order...
            var traverse = Traverse.Create(__instance);
            var map = traverse.Field("map").GetValue<Map>();
            if (!Main.BiomeSettings.TryGetValue(map.Biome, out var biomeSetting))
            {
                return true;
            }

            var weatherTemp = biomeSetting.BoundWeatherTemp(map.mapTemperature.OutdoorTemp);
            var rainAllowed = biomeSetting.CanIgnoreRainLimits()
                ? 0
                : traverse.Field("ticksWhenRainAllowedAgain").GetValue<int>();
            var preventRain = map.gameConditionManager.ActiveConditions.Any(x => x.def.preventRain);

            // If we're in the tutorial, just let it be
            if (TutorSystem.TutorialMode)
            {
                __result = WeatherDefOf.Clear;
                return false;
            }

            // Otherwise, try and figure out the weather by weight
            if (
                DefDatabase<WeatherDef>.AllDefs.TryRandomElementByWeight(
                    w => biomeSetting.GetWeatherData(w).GetCommonality(map, rainAllowed, weatherTemp, preventRain),
                    out var result))
            {
                //Log.Message($"newweather {result.defName}");
                __result = result;
                return false;
            }

            // If we didn't, use the default weather
            Log.Warning(
                "Unable to choose suitable weather; this may mean your biome specific settings don't produce a viable range of weathers.");
            __result = WeatherDefOf.Clear;
            return false;
        }
        catch (Exception exception)
        {
            Log.Error($"Unable to override choosing the next weather; falling back to vanilla. {exception}");
            return true;
        }
    }
}