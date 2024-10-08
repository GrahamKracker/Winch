namespace Winch.Api.Generators.GameReferences.WorldEventDatas;
public static class Ravens
{
    public static WorldEventData RavensInstance = (WorldEventData)System.Linq.Enumerable.First(ScriptableObjectInstances.WorldEventDatas, x => x.name == "Ravens");
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject prefab = RavensInstance.prefab;
    public static bool dispelByBanish = true;
    public static bool dispelByFoghorn = true;
    public static float foghornDispelTime = 1.5f;
    public static float foghornDispelCount = 3f;
    public static int minWorldPhase = 0;
    public static float minSanity = 0f;
    public static float maxSanity = 0.5f;
     ///<json>
     /// {
     ///    "NORMAL": 1.0,
     ///    "PASSIVE": 1.0,
     ///    "NIGHTMARE": 1.0,
     ///    "$type": "System.Collections.Generic.Dictionary`2[[GameMode, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]"
     ///}
     ///</json>
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = RavensInstance.repeatDelay;
    public static float weight = 5f;
    public static float spawnStartTime = 0.25f;
    public static float spawnEndTime = 0.75f;
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
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = RavensInstance.depthTestPath;
    public static bool isPath = false;
    public static float depthPathNumChecks = 5f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    public static ZoneEnum forbiddenZones = ZoneEnum.NONE;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "minNumber": 1,
     ///            "size": 3,
     ///            "max": true,
     ///            "min": false,
     ///            "itemType": "GENERAL,ALL",
     ///            "itemSubtype": "FISH,ALL",
     ///            "$type": "NumItemsOfSizeAndTypeCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[InventoryCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = RavensInstance.itemInventoryConditions;
    public static bool forbidOoze = false;
    public static bool allowInPassiveMode = false;
}
