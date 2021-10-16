using System;
using HarmonyLib;
using Verse;

namespace ColdDesertNights.Patches
{
    [HarmonyPatch(typeof(GenTemperature), nameof(GenTemperature.SeasonalShiftAmplitudeAt))]
    // ReSharper disable once UnusedMember.Global
    public static class SeasonalShiftAmplitudeAtPatch
    {
        public static bool Prefix(int tile, ref float __result)
        {
            try
            {
                var dist = Find.WorldGrid.DistanceFromEquatorNormalized(tile);
                var biome = Find.WorldGrid.tiles[tile].biome;
                if (!Main.BiomeSettings.ContainsKey(biome))
                {
                    return true;
                }

                var settings = Main.BiomeSettings[biome];
                __result = Find.WorldGrid.LongLatOf(tile).y >= 0.0
                    ? settings.CalculateSeasonalTemp(dist)
                    : -settings.CalculateSeasonalTemp(dist);
                return false;
            }
            catch (Exception exception)
            {
                Log.Error($"Unable to adjust seasonal temperature; falling back to vanilla. {exception}");
                return true;
            }
        }
    }
}