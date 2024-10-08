﻿using System;
using HarmonyLib;
using Winch.Core;
using Winch.Util;

namespace Winch.Patches.API;

[HarmonyPatch(typeof(Player))]
[HarmonyPatch("OnEnable")]
[HarmonyPriority(Priority.First)]
public class PlayerPatch
{
    public static void Postfix(Player __instance)
    {
        try
        {
            VibrationUtil.PopulateVibrationDatas();
            AbilityUtil.AddModdedAbilitiesToPlayer(__instance.transform.Find("Abilities"));
            PoiUtil.Populate();
            PoiUtil.CreateModdedPois();
            HarvestZoneUtil.CreateModdedHarvestZones();
            ItemUtil.Encyclopedia();
            WorldEventUtil.CreateModdedStaticWorldEvents();
        }
        catch (Exception ex)
        {
            WinchCore.Log.Error($"Error in {nameof(PlayerPatch)}: exception {ex}");
        }
    }
}
