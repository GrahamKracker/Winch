﻿using HarmonyLib;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using Winch.Util;

namespace Winch.Patches.API.Localization;

[HarmonyPatch(typeof(LocalizedStringDatabase))]
[HarmonyPatch("ProcessUntranslatedText")]
internal static class LocalizationRedirectPatcher
{
    public static bool Prefix(ref string __result, string key, long keyId, TableReference tableReference, StringTable table, UnityEngine.Localization.Locale locale)
    {
        string localeCode = locale.Identifier.Code;
        string? localized = LocalizationUtil.GetLocalizedString(localeCode, key);
        if (localized == null)
        {
            if (localeCode != "en")
            {
                localized = LocalizationUtil.GetLocalizedString("en", key); // Default to english
                if (localized == null)
                    return true;
            }
            else
                return true;
        }

        __result = localized;
        return false;
    }
}