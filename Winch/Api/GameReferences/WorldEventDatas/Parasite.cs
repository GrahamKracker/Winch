namespace Winch.Api.Generators.GameReferences.WorldEventDatas;
public static class Parasite
{
    public static WorldEventData ParasiteInstance = (WorldEventData)System.Linq.Enumerable.First(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Parasite");
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject prefab = ParasiteInstance.prefab;
    public static bool dispelByBanish = false;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 0;
    public static float minSanity = 0f;
    public static float maxSanity = 0.5f;
     ///<json>
     /// {
     ///    "NORMAL": 4.0,
     ///    "PASSIVE": 4.0,
     ///    "NIGHTMARE": 2.0,
     ///    "$type": "System.Collections.Generic.Dictionary`2[[GameMode, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]"
     ///}
     ///</json>
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = ParasiteInstance.repeatDelay;
    public static float weight = 3f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = false;
    public static float minDepth = 0f;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = ParasiteInstance.depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 5f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static bool doSafeZoneHitCheck = false;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static ZoneEnum forbiddenZones = ZoneEnum.NONE;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "minNumber": 1,
     ///            "itemType": "GENERAL,ALL",
     ///            "itemSubtype": "FISH,ALL",
     ///            "$type": "NumItemsOfTypeCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[InventoryCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = ParasiteInstance.itemInventoryConditions;
    public static bool forbidOoze = false;
    public static bool allowInPassiveMode = true;
}
