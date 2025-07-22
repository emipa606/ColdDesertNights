using System;
using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace ColdDesertNights.Patches;

[HarmonyPatch(typeof(GenTemperature), nameof(GenTemperature.OffsetFromSunCycle))]
// ReSharper disable once UnusedMember.Global
public static class GenTemperature_OffsetFromSunCycle
{
    // ReSharper disable once UnusedMember.Global
    public static bool Prefix(ref float __result, int absTick, PlanetTile tile)
    {
        try
        {
            var num = GenDate.DayPercent(absTick, Find.WorldGrid.LongLatOf(tile).x);
            var f = 6.28318548f * (num + 0.32f);
            var biome = tile.Tile.PrimaryBiome;
            if (!Main.BiomeSettings.ContainsKey(biome))
            {
                return true;
            }

            __result = Main.BiomeSettings[biome].CalculateTemp(f);
            return false;
        }
        catch (Exception exception)
        {
            Log.Error(
                $"Error getting biome for tile {tile} on world grid due to {exception} - {exception.StackTrace}");
            return true;
        }
    }
}