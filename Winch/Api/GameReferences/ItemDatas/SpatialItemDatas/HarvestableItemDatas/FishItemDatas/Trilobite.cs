namespace Winch.Api.Generators.GameReferences.ItemDatas.SpatialItemDatas.HarvestableItemDatas.FishItemDatas;
public static class Trilobite
{
    public static FishItemData TrilobiteInstance = (FishItemData)System.Linq.Enumerable.First(ScriptableObjectInstances.ItemDatas, x => x.name == "Trilobite");
    public static float minSizeCentimeters = 40f;
    public static float maxSizeCentimeters = 60f;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "minSizeCentimeters": 40.0,
     ///            "maxSizeCentimeters": 60.0,
     ///            "aberrations": [],
     ///            "isAberration": true,
     ///            "nonAberrationParent": {
     ///                "minSizeCentimeters": 40.0,
     ///                "maxSizeCentimeters": 60.0,
     ///                "aberrations": {
     ///                    "$ref": "0"
     ///                },
     ///                "isAberration": false,
     ///                "nonAberrationParent": null,
     ///                "minWorldPhaseRequired": 0,
     ///                "locationHiddenUntilCaught": false,
     ///                "day": true,
     ///                "night": true,
     ///                "canAppearInBaitBalls": true,
     ///                "questCompleteRequired": null,
     ///                "baitChanceOverride": -1.0,
     ///                "canBeInfected": true,
     ///                "cellsExcludedFromDisplayingInfection": [],
     ///                "rotCoefficient": 0.5,
     ///                "tirPhase": 2,
     ///                "harvestMinigameType": "FISHING_SPIRAL",
     ///                "perSpotMin": 1,
     ///                "perSpotMax": 1,
     ///                "harvestItemWeight": 5.0,
     ///                "regenHarvestSpotOnDestroy": false,
     ///                "harvestPOICategory": "FISH_MEDIUM",
     ///                "harvestableType": "CRAB",
     ///                "requiresAdvancedEquipment": false,
     ///                "harvestDifficulty": "VERY_EASY",
     ///                "canBeReplacedWithResearchItem": false,
     ///                "canBeCaughtByRod": false,
     ///                "canBeCaughtByPot": true,
     ///                "canBeCaughtByNet": false,
     ///                "affectedByFishingSustain": true,
     ///                "hasMinDepth": false,
     ///                "minDepth": "VERY_SHALLOW",
     ///                "hasMaxDepth": true,
     ///                "maxDepth": "DEEP",
     ///                "zonesFoundIn": "GALE_CLIFFS,ALL",
     ///                "canBeSoldByPlayer": true,
     ///                "canBeSoldInBulkAction": true,
     ///                "value": 14.0,
     ///                "hasSellOverride": false,
     ///                "sellOverrideValue": 0.0,
     ///                "sprite": {
     ///
     ///                },
     ///                "platformSpecificSpriteOverrides": null,
     ///                "itemColor": {
     ///                    "r": 0.227451,
     ///                    "g": 0.1568628,
     ///                    "b": 0.1254902,
     ///                    "a": 1.0
     ///                },
     ///                "hasSpecialDiscardAction": false,
     ///                "discardPromptOverride": "",
     ///                "canBeDiscardedByPlayer": true,
     ///                "showAlertOnDiscardHold": false,
     ///                "discardHoldTimeOverride": false,
     ///                "discardHoldTimeSec": 0.0,
     ///                "canBeDiscardedDuringQuestPickup": true,
     ///                "damageMode": "DESTROY",
     ///                "moveMode": "FREE",
     ///                "ignoreDamageWhenPlacing": false,
     ///                "isUnderlayItem": false,
     ///                "forbidStorageTray": false,
     ///                "dimensions": [
     ///                    {
     ///
     ///                    },
     ///                    {
     ///
     ///                    }
     ///                ],
     ///                "squishFactor": 0.25,
     ///                "itemOwnPrerequisites": [],
     ///                "researchPrerequisites": [],
     ///                "researchPointsRequired": 0,
     ///                "buyableWithoutResearch": false,
     ///                "researchIsForRecipe": false,
     ///                "useIntenseAberratedUIShader": false,
     ///                "id": "trilobite",
     ///                "itemNameKey": [],
     ///                "itemDescriptionKey": [],
     ///                "hasAdditionalNote": false,
     ///                "additionalNoteKey": [],
     ///                "itemInsaneTitleKey": [],
     ///                "itemInsaneDescriptionKey": [],
     ///                "linkedDialogueNode": "",
     ///                "dialogueNodeSpecificDescription": [],
     ///                "itemType": "GENERAL,ALL",
     ///                "itemSubtype": "FISH,ALL",
     ///                "tooltipTextColor": {
     ///                    "r": 0.4901961,
     ///                    "g": 0.3843137,
     ///                    "b": 0.2666667,
     ///                    "a": 1.0
     ///                },
     ///                "tooltipNotesColor": {
     ///                    "r": 1.0,
     ///                    "g": 1.0,
     ///                    "b": 1.0,
     ///                    "a": 1.0
     ///                },
     ///                "itemTypeIcon": {
     ///                    "$id": "15"
     ///                },
     ///                "harvestParticlePrefab": null,
     ///                "overrideHarvestParticleDepth": false,
     ///                "harvestParticleDepthOffset": -3.0,
     ///                "flattenParticleShape": false,
     ///                "availableInDemo": false,
     ///                "entitlementsRequired": [
     ///                    "DLC_2"
     ///                ]
     ///            },
     ///            "minWorldPhaseRequired": 0,
     ///            "locationHiddenUntilCaught": false,
     ///            "day": true,
     ///            "night": true,
     ///            "canAppearInBaitBalls": true,
     ///            "questCompleteRequired": null,
     ///            "baitChanceOverride": -1.0,
     ///            "canBeInfected": true,
     ///            "cellsExcludedFromDisplayingInfection": [],
     ///            "rotCoefficient": 0.5,
     ///            "tirPhase": 2,
     ///            "harvestMinigameType": "FISHING_SPIRAL",
     ///            "perSpotMin": 1,
     ///            "perSpotMax": 1,
     ///            "harvestItemWeight": 5.0,
     ///            "regenHarvestSpotOnDestroy": false,
     ///            "harvestPOICategory": "FISH_MEDIUM",
     ///            "harvestableType": "CRAB",
     ///            "requiresAdvancedEquipment": false,
     ///            "harvestDifficulty": "VERY_EASY",
     ///            "canBeReplacedWithResearchItem": false,
     ///            "canBeCaughtByRod": false,
     ///            "canBeCaughtByPot": true,
     ///            "canBeCaughtByNet": false,
     ///            "affectedByFishingSustain": true,
     ///            "hasMinDepth": false,
     ///            "minDepth": "VERY_SHALLOW",
     ///            "hasMaxDepth": true,
     ///            "maxDepth": "DEEP",
     ///            "zonesFoundIn": "GALE_CLIFFS,ALL",
     ///            "canBeSoldByPlayer": true,
     ///            "canBeSoldInBulkAction": true,
     ///            "value": 35.0,
     ///            "hasSellOverride": false,
     ///            "sellOverrideValue": 0.0,
     ///            "sprite": {
     ///
     ///            },
     ///            "platformSpecificSpriteOverrides": null,
     ///            "itemColor": {
     ///                "r": 0.5333334,
     ///                "g": 0.0,
     ///                "b": 0.2980392,
     ///                "a": 1.0
     ///            },
     ///            "hasSpecialDiscardAction": false,
     ///            "discardPromptOverride": "",
     ///            "canBeDiscardedByPlayer": true,
     ///            "showAlertOnDiscardHold": false,
     ///            "discardHoldTimeOverride": false,
     ///            "discardHoldTimeSec": 0.0,
     ///            "canBeDiscardedDuringQuestPickup": true,
     ///            "damageMode": "DESTROY",
     ///            "moveMode": "FREE",
     ///            "ignoreDamageWhenPlacing": false,
     ///            "isUnderlayItem": false,
     ///            "forbidStorageTray": false,
     ///            "dimensions": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "squishFactor": 0.25,
     ///            "itemOwnPrerequisites": [],
     ///            "researchPrerequisites": [],
     ///            "researchPointsRequired": 0,
     ///            "buyableWithoutResearch": false,
     ///            "researchIsForRecipe": false,
     ///            "useIntenseAberratedUIShader": false,
     ///            "id": "trilobite-ab-1",
     ///            "itemNameKey": [],
     ///            "itemDescriptionKey": [],
     ///            "hasAdditionalNote": false,
     ///            "additionalNoteKey": [],
     ///            "itemInsaneTitleKey": [],
     ///            "itemInsaneDescriptionKey": [],
     ///            "linkedDialogueNode": "",
     ///            "dialogueNodeSpecificDescription": [],
     ///            "itemType": "GENERAL,ALL",
     ///            "itemSubtype": "FISH,ALL",
     ///            "tooltipTextColor": {
     ///                "r": 0.5333334,
     ///                "g": 0.0,
     ///                "b": 0.2980392,
     ///                "a": 1.0
     ///            },
     ///            "tooltipNotesColor": {
     ///                "r": 1.0,
     ///                "g": 1.0,
     ///                "b": 1.0,
     ///                "a": 1.0
     ///            },
     ///            "itemTypeIcon": {
     ///                "$ref": "15"
     ///            },
     ///            "harvestParticlePrefab": null,
     ///            "overrideHarvestParticleDepth": false,
     ///            "harvestParticleDepthOffset": -3.0,
     ///            "flattenParticleShape": false,
     ///            "availableInDemo": false,
     ///            "entitlementsRequired": [
     ///                "DLC_2"
     ///            ]
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[FishItemData, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]",
     ///    "$id": "0"
     ///}
     ///</json>
    public static System.Collections.Generic.List<FishItemData> aberrations = TrilobiteInstance.aberrations;
    public static bool isAberration = false;
     ///<json>
     /// null
     /// </json>
    public static FishItemData nonAberrationParent = null;
    public static int minWorldPhaseRequired = 0;
    public static bool locationHiddenUntilCaught = false;
    public static bool day = true;
    public static bool night = true;
    public static bool canAppearInBaitBalls = true;
     ///<json>
     /// null
     /// </json>
    public static QuestData questCompleteRequired = null;
    public static float baitChanceOverride = -1f;
    public static bool canBeInfected = true;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector2Int, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> cellsExcludedFromDisplayingInfection = TrilobiteInstance.cellsExcludedFromDisplayingInfection;
    public static float rotCoefficient = 0.5f;
    public static int tirPhase = 2;
    public static HarvestMinigameType harvestMinigameType = HarvestMinigameType.FISHING_SPIRAL;
    public static int perSpotMin = 1;
    public static int perSpotMax = 1;
    public static float harvestItemWeight = 5f;
    public static bool regenHarvestSpotOnDestroy = false;
    public static HarvestPOICategory harvestPOICategory = HarvestPOICategory.FISH_MEDIUM;
    public static HarvestableType harvestableType = HarvestableType.CRAB;
    public static bool requiresAdvancedEquipment = false;
    public static HarvestDifficulty harvestDifficulty = HarvestDifficulty.VERY_EASY;
    public static bool canBeReplacedWithResearchItem = false;
    public static bool canBeCaughtByRod = false;
    public static bool canBeCaughtByPot = true;
    public static bool canBeCaughtByNet = false;
    public static bool affectedByFishingSustain = true;
    public static ZoneEnum zonesFoundIn = ZoneEnum.NONE | ZoneEnum.GALE_CLIFFS;
    public static bool canBeSoldByPlayer = true;
    public static bool canBeSoldInBulkAction = true;
    public static System.Decimal value = 14m;
    public static bool hasSellOverride = false;
    public static System.Decimal sellOverrideValue = 0m;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite sprite = TrilobiteInstance.sprite;
    public static UnityEngine.Color itemColor = new UnityEngine.Color(0.227451f, 0.1568628f, 0.1254902f, 1f);
    public static bool hasSpecialDiscardAction = false;
    public static string discardPromptOverride = "";
    public static bool canBeDiscardedByPlayer = true;
    public static bool showAlertOnDiscardHold = false;
    public static bool discardHoldTimeOverride = false;
    public static float discardHoldTimeSec = 0f;
    public static bool canBeDiscardedDuringQuestPickup = true;
    public static DamageMode damageMode = DamageMode.DESTROY;
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
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[UnityEngine.Vector2Int, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> dimensions = TrilobiteInstance.dimensions;
    public static float squishFactor = 0.25f;
    public static string id = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemNameKey = TrilobiteInstance.itemNameKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemDescriptionKey = TrilobiteInstance.itemDescriptionKey;
    public static bool hasAdditionalNote = false;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString additionalNoteKey = TrilobiteInstance.additionalNoteKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneTitleKey = TrilobiteInstance.itemInsaneTitleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneDescriptionKey = TrilobiteInstance.itemInsaneDescriptionKey;
    public static string linkedDialogueNode = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString dialogueNodeSpecificDescription = TrilobiteInstance.dialogueNodeSpecificDescription;
    public static ItemType itemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype itemSubtype = ItemSubtype.NONE | ItemSubtype.FISH;
    public static UnityEngine.Color tooltipTextColor = new UnityEngine.Color(0.4901961f, 0.3843137f, 0.2666667f, 1f);
    public static UnityEngine.Color tooltipNotesColor = new UnityEngine.Color(1f, 1f, 1f, 1f);
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite itemTypeIcon = TrilobiteInstance.itemTypeIcon;
     ///<json>
     /// null
     /// </json>
    public static UnityEngine.GameObject harvestParticlePrefab = null;
    public static bool overrideHarvestParticleDepth = false;
    public static float harvestParticleDepthOffset = -3f;
    public static bool flattenParticleShape = false;
    public static bool availableInDemo = false;
     ///<json>
     /// {
     ///    "$content": [
     ///        "DLC_2"
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[Entitlement, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<Entitlement> entitlementsRequired = TrilobiteInstance.entitlementsRequired;
}
