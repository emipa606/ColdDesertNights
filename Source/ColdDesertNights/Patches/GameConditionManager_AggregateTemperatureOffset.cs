using System;
using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ColdDesertNights.Patches;

[HarmonyPatch(typeof(GameConditionManager), "AggregateTemperatureOffset")]
// ReSharper disable once UnusedMember.Global
public static class GameConditionManager_AggregateTemperatureOffset
{
    public static bool Prefix(GameConditionManager __instance, ref float __result)
    {
        try
        {
            if (!Main.BiomeSettings.TryGetValue(__instance.ownerMap.Biome, out var setting))
            {
                return true;
            }

            __result = getOffset(__instance, setting);
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
    private static float getOffset(GameConditionManager manager, BiomeData data)
    {
        // Add up all the various offsets we have:
        var num = manager.ActiveConditions.Sum(data.GetBiomeConditionTemperatureOffset);

        if (manager.Parent != null)
        {
            num += getOffset(manager.Parent, data);
        }

        return num;
    }
}