namespace Winch.Api.Generators.GameReferences.WorldEventDatas;
public static class MonsterRayAttack2
{
    public static WorldEventData MonsterRayAttack2Instance = (WorldEventData)System.Linq.Enumerable.First(ScriptableObjectInstances.WorldEventDatas, x => x.name == "MonsterRayAttack2");
    public static WorldEventType eventType = WorldEventType.SPAWN_PREFAB;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject prefab = MonsterRayAttack2Instance.prefab;
    public static bool dispelByBanish = true;
    public static bool dispelByFoghorn = false;
    public static float foghornDispelTime = 0f;
    public static float foghornDispelCount = 0f;
    public static int minWorldPhase = 3;
    public static float minSanity = 0f;
    public static float maxSanity = 0.25f;
     ///<json>
     /// {
     ///    "NORMAL": 5.0,
     ///    "PASSIVE": 5.0,
     ///    "NIGHTMARE": 0.25,
     ///    "$type": "System.Collections.Generic.Dictionary`2[[GameMode, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]"
     ///}
     ///</json>
    public static System.Collections.Generic.Dictionary<GameMode,float> repeatDelay = MonsterRayAttack2Instance.repeatDelay;
    public static float weight = 3f;
    public static float spawnStartTime = 0f;
    public static float spawnEndTime = 1f;
    public static bool hasDuration = false;
    public static float durationSec = 0f;
    public static bool hasMinDepth = true;
    public static float minDepth = 0.05f;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "x": 25.0,
     ///            "y": 0.0,
     ///            "z": 25.0
     ///        },
     ///        {
     ///            "x": 0.0,
     ///            "y": 0.0,
     ///            "z": 0.0
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector3> depthTestPath = MonsterRayAttack2Instance.depthTestPath;
    public static bool isPath = true;
    public static float depthPathNumChecks = 10f;
    public static UnityEngine.Vector3 playerSpawnOffset = new UnityEngine.Vector3(25f, 0f, 25f);
    public static UnityEngine.Vector3 zoneTestOffset = new UnityEngine.Vector3(25f, 0f, 25f);
    public static bool doSafeZoneHitCheck = true;
    public static UnityEngine.Vector3 safeZoneHitCheckOffset = new UnityEngine.Vector3(25f, 0f, 25f);
    public static ZoneEnum forbiddenZones = ZoneEnum.NONE | ZoneEnum.TWISTED_STRAND | ZoneEnum.DEVILS_SPINE | ZoneEnum.PALE_REACH;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[InventoryCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<InventoryCondition> itemInventoryConditions = MonsterRayAttack2Instance.itemInventoryConditions;
    public static bool forbidOoze = false;
    public static bool allowInPassiveMode = false;
}
