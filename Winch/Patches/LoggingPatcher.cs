using HarmonyLib;
using Winch.Core;

namespace Winch.Patches;

[HarmonyPatch]
internal static class LoggingPatcher
{
    [HarmonyPatch(typeof(CustomDebug), nameof(CustomDebug.Log))]
    [HarmonyPrefix]
    public static void LogPrefix(string message) => WinchCore.Log.Debug(message);
    
    [HarmonyPatch(typeof(CustomDebug), nameof(CustomDebug.LogWarning))]
    [HarmonyPrefix]
    public static void LogWarningPrefix(string message) => WinchCore.Log.Warn(message);

    [HarmonyPatch(typeof(CustomDebug), nameof(CustomDebug.LogError))]
    [HarmonyPrefix]
    public static void LogErrorPrefix(string message) => WinchCore.Log.Error(message);

    [HarmonyPatch(typeof(CustomDebug), nameof(CustomDebug.EditorLog))]
    [HarmonyPrefix]
    public static void EditorLogPrefix(string message) => WinchCore.Log.Debug(message);

    [HarmonyPatch(typeof(CustomDebug), nameof(CustomDebug.EditorLogWarning))]
    [HarmonyPrefix]
    public static void EditorLogWarningPrefix(string message) => WinchCore.Log.Warn(message);

    [HarmonyPatch(typeof(CustomDebug), nameof(CustomDebug.EditorLogError))]
    [HarmonyPrefix]
    public static void EditorLogErrorPrefix(string message) => WinchCore.Log.Error(message);

    [HarmonyPatch(typeof(CustomDebug), nameof(CustomDebug.Init))]
    [HarmonyPrefix]
    public static bool InitPrefix()
    {
        WinchCore.Log.Debug("CustomDebug.Init()");
        return false;
    }
}