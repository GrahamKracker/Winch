namespace Winch.Api.Generators.GameReferences.ItemDatas.SpatialItemDatas.HarvestableItemDatas;
public static class Mortar1
{
    public static HarvestableItemData Mortar1Instance = (HarvestableItemData)System.Linq.Enumerable.First(ScriptableObjectInstances.ItemDatas, x => x.name == "Mortar1");
    public static HarvestMinigameType harvestMinigameType = HarvestMinigameType.DREDGE_RADIAL;
    public static int perSpotMin = 1;
    public static int perSpotMax = 1;
    public static float harvestItemWeight = 1f;
    public static bool regenHarvestSpotOnDestroy = true;
    public static HarvestPOICategory harvestPOICategory = HarvestPOICategory.TRINKET;
    public static HarvestableType harvestableType = HarvestableType.DREDGE;
    public static bool requiresAdvancedEquipment = false;
    public static HarvestDifficulty harvestDifficulty = HarvestDifficulty.HARD;
    public static bool canBeReplacedWithResearchItem = false;
    public static bool canBeCaughtByRod = false;
    public static bool canBeCaughtByPot = false;
    public static bool canBeCaughtByNet = false;
    public static bool affectedByFishingSustain = true;
    public static bool hasMinDepth = false;
    public static DepthEnum minDepth = DepthEnum.VERY_SHALLOW;
    public static bool hasMaxDepth = false;
    public static DepthEnum maxDepth = DepthEnum.VERY_SHALLOW;
    public static ZoneEnum zonesFoundIn = ZoneEnum.NONE | ZoneEnum.TWISTED_STRAND;
    public static bool canBeSoldByPlayer = false;
    public static bool canBeSoldInBulkAction = true;
    public static System.Decimal value = 0m;
    public static bool hasSellOverride = false;
    public static System.Decimal sellOverrideValue = 0m;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite sprite = Mortar1Instance.sprite;
    public static UnityEngine.Color itemColor = new UnityEngine.Color(0.227451f, 0.1568628f, 0.1254902f, 255f);
    public static bool hasSpecialDiscardAction = false;
    public static string discardPromptOverride = "";
    public static bool canBeDiscardedByPlayer = false;
    public static bool showAlertOnDiscardHold = false;
    public static bool discardHoldTimeOverride = false;
    public static float discardHoldTimeSec = 0f;
    public static bool canBeDiscardedDuringQuestPickup = false;
    public static DamageMode damageMode = DamageMode.NONE;
    public static MoveMode moveMode = MoveMode.FREE;
    public static bool ignoreDamageWhenPlacing = false;
    public static bool isUnderlayItem = false;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///
     ///        },
     ///        {
     ///
     ///        },
     ///        {
     ///
     ///        },
     ///        {
     ///
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector2Int, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> dimensions = Mortar1Instance.dimensions;
    public static float squishFactor = 0f;
    public static string id = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemNameKey = Mortar1Instance.itemNameKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemDescriptionKey = Mortar1Instance.itemDescriptionKey;
    public static bool hasAdditionalNote = false;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString additionalNoteKey = Mortar1Instance.additionalNoteKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneTitleKey = Mortar1Instance.itemInsaneTitleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneDescriptionKey = Mortar1Instance.itemInsaneDescriptionKey;
    public static string linkedDialogueNode = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString dialogueNodeSpecificDescription = Mortar1Instance.dialogueNodeSpecificDescription;
    public static ItemType itemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype itemSubtype = ItemSubtype.NONE | ItemSubtype.GENERAL;
    public static UnityEngine.Color tooltipTextColor = new UnityEngine.Color(0.4901961f, 0.3843137f, 0.2666667f, 1f);
    public static UnityEngine.Color tooltipNotesColor = new UnityEngine.Color(1f, 1f, 1f, 1f);
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite itemTypeIcon = Mortar1Instance.itemTypeIcon;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject harvestParticlePrefab = Mortar1Instance.harvestParticlePrefab;
    public static bool overrideHarvestParticleDepth = false;
    public static float harvestParticleDepthOffset = -3f;
    public static bool flattenParticleShape = false;
    public static bool availableInDemo = true;
     ///<json>
     /// {
     ///    "$content": [
     ///        "NONE"
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[Entitlement, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<Entitlement> entitlementsRequired = Mortar1Instance.entitlementsRequired;
}
