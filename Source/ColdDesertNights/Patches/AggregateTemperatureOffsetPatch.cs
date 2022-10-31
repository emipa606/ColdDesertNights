using System;
using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ColdDesertNights.Patches;

[HarmonyPatch(typeof(GameConditionManager), "AggregateTemperatureOffset")]
// ReSharper disable once UnusedMember.Global
public static class AggregateTemperatureOffsetPatch
{
    public static bool Prefix(GameConditionManager __instance, ref float __result)
    {
        try
        {
            if (!Main.BiomeSettings.ContainsKey(__instance.ownerMap.Biome))
            {
                return true;
            }

            __result = GetOffset(__instance, Main.BiomeSettings[__instance.ownerMap.Biome]);
            return false;
        }
        catch (Exception exception)
        {
            Log.Error(
                $"Unable to override game condition temperature offsets; falling back to vanilla. {exception}");
            return true;
        }
    }

    /// <summary>
    ///     Gets the offset for the given condition manager, recursively checking any parent managers we have
    /// </summary>
    /// <param name="manager">The condition manager to check</param>
    /// <param name="data">The <see cref="BiomeData" /> to use</param>
    /// <returns>The aggregated offset</returns>
    private static float GetOffset(GameConditionManager manager, BiomeData data)
    {
        // Add up all the various offsets we have:
        var num = manager.ActiveConditions.Sum(data.GetBiomeConditionTemperatureOffset);

        if (manager.Parent != null)
        {
            num += GetOffset(manager.Parent, data);
        }

        return num;
    }
}