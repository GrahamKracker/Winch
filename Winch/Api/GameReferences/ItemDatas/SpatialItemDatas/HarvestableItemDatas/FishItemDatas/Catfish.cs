namespace Winch.Api.GameReferences.ItemDatas.SpatialItemDatas.HarvestableItemDatas.FishItemDatas;
public static class Catfish
{
    public static FishItemData CatfishInstance = (FishItemData)System.Linq.Enumerable.First(ScriptableObjectInstances.ItemDatas, x => x.name == "Catfish");
    public static float minSizeCentimeters = 40f;
    public static float maxSizeCentimeters = 120f;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "minSizeCentimeters": 40.0,
     ///            "maxSizeCentimeters": 120.0,
     ///            "aberrations": [],
     ///            "isAberration": true,
     ///            "nonAberrationParent": {
     ///                "minSizeCentimeters": 40.0,
     ///                "maxSizeCentimeters": 120.0,
     ///                "aberrations": {
     ///                    "$ref": "0"
     ///                },
     ///                "isAberration": false,
     ///                "nonAberrationParent": null,
     ///                "minWorldPhaseRequired": 0,
     ///                "locationHiddenUntilCaught": false,
     ///                "day": false,
     ///                "night": true,
     ///                "canAppearInBaitBalls": true,
     ///                "questCompleteRequired": null,
     ///                "baitChanceOverride": -1.0,
     ///                "canBeInfected": true,
     ///                "cellsExcludedFromDisplayingInfection": [],
     ///                "rotCoefficient": 1.0,
     ///                "tirPhase": 0,
     ///                "harvestMinigameType": "FISHING_PENDULUM",
     ///                "perSpotMin": 1,
     ///                "perSpotMax": 3,
     ///                "harvestItemWeight": 1.0,
     ///                "regenHarvestSpotOnDestroy": false,
     ///                "harvestPOICategory": "FISH_LARGE",
     ///                "harvestableType": "MANGROVE",
     ///                "requiresAdvancedEquipment": false,
     ///                "harvestDifficulty": "VERY_HARD",
     ///                "canBeReplacedWithResearchItem": false,
     ///                "canBeCaughtByRod": true,
     ///                "canBeCaughtByPot": false,
     ///                "canBeCaughtByNet": true,
     ///                "affectedByFishingSustain": true,
     ///                "hasMinDepth": false,
     ///                "minDepth": "MEDIUM",
     ///                "hasMaxDepth": false,
     ///                "maxDepth": null,
     ///                "zonesFoundIn": "TWISTED_STRAND,ALL",
     ///                "canBeSoldByPlayer": true,
     ///                "canBeSoldInBulkAction": true,
     ///                "value": 70.0,
     ///                "hasSellOverride": false,
     ///                "sellOverrideValue": 0.0,
     ///                "sprite": {
     ///
     ///                },
     ///                "platformSpecificSpriteOverrides": null,
     ///                "itemColor": {
     ///                    "r": 0.2264151,
     ///                    "g": 0.1562912,
     ///                    "b": 0.1249555,
     ///                    "a": 255.0
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
     ///                    },
     ///                    {
     ///
     ///                    },
     ///                    {
     ///
     ///                    },
     ///                    {
     ///
     ///                    },
     ///                    {
     ///
     ///                    }
     ///                ],
     ///                "squishFactor": 1.0,
     ///                "itemOwnPrerequisites": [],
     ///                "researchPrerequisites": [],
     ///                "researchPointsRequired": 0,
     ///                "buyableWithoutResearch": false,
     ///                "researchIsForRecipe": false,
     ///                "useIntenseAberratedUIShader": false,
     ///                "id": "catfish",
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
     ///                "harvestParticlePrefab": {
     ///                    "$id": "16"
     ///                },
     ///                "overrideHarvestParticleDepth": true,
     ///                "harvestParticleDepthOffset": -2.25,
     ///                "flattenParticleShape": true,
     ///                "availableInDemo": true,
     ///                "entitlementsRequired": [
     ///                    "NONE"
     ///                ]
     ///            },
     ///            "minWorldPhaseRequired": 0,
     ///            "locationHiddenUntilCaught": false,
     ///            "day": false,
     ///            "night": true,
     ///            "canAppearInBaitBalls": true,
     ///            "questCompleteRequired": null,
     ///            "baitChanceOverride": -1.0,
     ///            "canBeInfected": true,
     ///            "cellsExcludedFromDisplayingInfection": [],
     ///            "rotCoefficient": 1.0,
     ///            "tirPhase": 0,
     ///            "harvestMinigameType": "FISHING_PENDULUM",
     ///            "perSpotMin": 1,
     ///            "perSpotMax": 3,
     ///            "harvestItemWeight": 1.0,
     ///            "regenHarvestSpotOnDestroy": false,
     ///            "harvestPOICategory": "FISH_LARGE",
     ///            "harvestableType": "MANGROVE",
     ///            "requiresAdvancedEquipment": false,
     ///            "harvestDifficulty": "VERY_HARD",
     ///            "canBeReplacedWithResearchItem": false,
     ///            "canBeCaughtByRod": true,
     ///            "canBeCaughtByPot": false,
     ///            "canBeCaughtByNet": true,
     ///            "affectedByFishingSustain": true,
     ///            "hasMinDepth": false,
     ///            "minDepth": "MEDIUM",
     ///            "hasMaxDepth": false,
     ///            "maxDepth": null,
     ///            "zonesFoundIn": "TWISTED_STRAND,ALL",
     ///            "canBeSoldByPlayer": true,
     ///            "canBeSoldInBulkAction": true,
     ///            "value": 180.0,
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
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "squishFactor": 1.0,
     ///            "itemOwnPrerequisites": [],
     ///            "researchPrerequisites": [],
     ///            "researchPointsRequired": 0,
     ///            "buyableWithoutResearch": false,
     ///            "researchIsForRecipe": false,
     ///            "useIntenseAberratedUIShader": false,
     ///            "id": "catfish-ab-1",
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
     ///            "harvestParticlePrefab": {
     ///                "$ref": "16"
     ///            },
     ///            "overrideHarvestParticleDepth": true,
     ///            "harvestParticleDepthOffset": -2.25,
     ///            "flattenParticleShape": true,
     ///            "availableInDemo": true,
     ///            "entitlementsRequired": [
     ///                "NONE"
     ///            ]
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[FishItemData, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]",
     ///    "$id": "0"
     ///}
     ///</json>
    public static System.Collections.Generic.List<FishItemData> aberrations = CatfishInstance.aberrations;
    public static bool isAberration = false;
     ///<json>
     /// null
     /// </json>
    public static FishItemData nonAberrationParent = null;
    public static int minWorldPhaseRequired = 0;
    public static bool locationHiddenUntilCaught = false;
    public static bool day = false;
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
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> cellsExcludedFromDisplayingInfection = CatfishInstance.cellsExcludedFromDisplayingInfection;
    public static float rotCoefficient = 1f;
    public static int tirPhase = 0;
    public static HarvestMinigameType harvestMinigameType = HarvestMinigameType.FISHING_PENDULUM;
    public static int perSpotMin = 1;
    public static int perSpotMax = 3;
    public static float harvestItemWeight = 1f;
    public static bool regenHarvestSpotOnDestroy = false;
    public static HarvestPOICategory harvestPOICategory = HarvestPOICategory.FISH_LARGE;
    public static HarvestableType harvestableType = HarvestableType.MANGROVE;
    public static bool requiresAdvancedEquipment = false;
    public static HarvestDifficulty harvestDifficulty = HarvestDifficulty.VERY_HARD;
    public static bool canBeReplacedWithResearchItem = false;
    public static bool canBeCaughtByRod = true;
    public static bool canBeCaughtByPot = false;
    public static bool canBeCaughtByNet = true;
    public static bool affectedByFishingSustain = true;
    public static ZoneEnum zonesFoundIn = ZoneEnum.NONE | ZoneEnum.TWISTED_STRAND;
    public static bool canBeSoldByPlayer = true;
    public static bool canBeSoldInBulkAction = true;
    public static System.Decimal value = 70m;
    public static bool hasSellOverride = false;
    public static System.Decimal sellOverrideValue = 0m;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite sprite = CatfishInstance.sprite;
    public static UnityEngine.Color itemColor = new UnityEngine.Color(0.2264151f, 0.1562912f, 0.1249555f, 255f);
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
     ///        },
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
    public static System.Collections.Generic.List<UnityEngine.Vector2Int> dimensions = CatfishInstance.dimensions;
    public static float squishFactor = 1f;
    public static string id = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemNameKey = CatfishInstance.itemNameKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemDescriptionKey = CatfishInstance.itemDescriptionKey;
    public static bool hasAdditionalNote = false;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString additionalNoteKey = CatfishInstance.additionalNoteKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneTitleKey = CatfishInstance.itemInsaneTitleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString itemInsaneDescriptionKey = CatfishInstance.itemInsaneDescriptionKey;
    public static string linkedDialogueNode = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString dialogueNodeSpecificDescription = CatfishInstance.dialogueNodeSpecificDescription;
    public static ItemType itemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype itemSubtype = ItemSubtype.NONE | ItemSubtype.FISH;
    public static UnityEngine.Color tooltipTextColor = new UnityEngine.Color(0.4901961f, 0.3843137f, 0.2666667f, 1f);
    public static UnityEngine.Color tooltipNotesColor = new UnityEngine.Color(1f, 1f, 1f, 1f);
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.Sprite itemTypeIcon = CatfishInstance.itemTypeIcon;
     ///<json>
     /// Serialization does not support this type.
     /// </json>
    public static UnityEngine.GameObject harvestParticlePrefab = CatfishInstance.harvestParticlePrefab;
    public static bool overrideHarvestParticleDepth = true;
    public static float harvestParticleDepthOffset = -2.25f;
    public static bool flattenParticleShape = true;
    public static bool availableInDemo = true;
     ///<json>
     /// {
     ///    "$content": [
     ///        "NONE"
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[Entitlement, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<Entitlement> entitlementsRequired = CatfishInstance.entitlementsRequired;
}
