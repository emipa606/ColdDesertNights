using System;
using HarmonyLib;
using RimWorld.Planet;
using Verse;

namespace ColdDesertNights.Patches;

[HarmonyPatch(typeof(GenTemperature), nameof(GenTemperature.SeasonalShiftAmplitudeAt))]
// ReSharper disable once UnusedMember.Global
public static class GenTemperature_SeasonalShiftAmplitudeAt
{
    public static bool Prefix(PlanetTile tile, ref float __result)
    {
        try
        {
            var dist = Find.WorldGrid.DistanceFromEquatorNormalized(tile);
            var biome = tile.Tile.PrimaryBiome;
            if (!Main.BiomeSettings.TryGetValue(biome, out var settings))
            {
                return true;
            }

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