using HarmonyLib;

namespace Winch.Api.Patches.GameManager;

[HarmonyPatch(typeof(global::GameManager), nameof(global::GameManager.WaitForAllAsyncManagers))]
internal static class GameManager_WaitForAllAsyncManagers
{
    [HarmonyPostfix]
    private static void Postfix()
    {
        AbyssEvents.InvokeGameManagersLoaded();
    }
}