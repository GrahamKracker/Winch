namespace Winch.Api.Generators.GameReferences.QuestGridConfigs;
public static class HoodedFigure5B
{
    public static QuestGridConfig HoodedFigure5BInstance = (QuestGridConfig)System.Linq.Enumerable.First(ScriptableObjectInstances.QuestGridConfigs, x => x.name == "HoodedFigure5B");
    public static QuestGridExitMode questGridExitMode = QuestGridExitMode.ITEM_DELIVER;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString titleString = HoodedFigure5BInstance.titleString;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString helpStringOverride = HoodedFigure5BInstance.helpStringOverride;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString exitPromptOverride = HoodedFigure5BInstance.exitPromptOverride;
     ///<json>
     /// null
     /// </json>
    public static UnityEngine.Sprite backgroundImage = null;
    public static float gridHeightOverride = 0f;
    public static bool overrideGridCellColor = true;
    public static DredgeColorTypeEnum gridCellColor = DredgeColorTypeEnum.CRITICAL;
    public static bool allowStorageAccess = false;
    public static bool isSaved = false;
    public static bool createItemsIfEmpty = false;
    public static GridKey gridKey = GridKey.SHRINE_DS_1;
    public static bool allowManualExit = true;
    public static bool allowEquipmentInstallation = false;
    public static bool createWithDurabilityValue = false;
    public static float startingDurabilityProportion = 1f;
     ///<json>
     /// {
     ///    "cellGroupConfigs": [],
     ///    "mainItemType": "GENERAL,ALL",
     ///    "mainItemSubtype": "FISH,ALL",
     ///    "mainItemData": null,
     ///    "itemsInThisBelongToPlayer": false,
     ///    "canAddItemsInQuestMode": true,
     ///    "hasUnderlay": false,
     ///    "columns": 1,
     ///    "rows": 2,
     ///    "$type": "GridConfiguration"
     ///}
     ///</json>
    public static GridConfiguration gridConfiguration = HoodedFigure5BInstance.gridConfiguration;
     ///<json>
     /// {
     ///    "spatialUnderlayItems": [],
     ///    "spatialItems": [
     ///        {
     ///            "x": 0,
     ///            "y": 0,
     ///            "z": 0,
     ///            "durability": 0.0,
     ///            "seen": false,
     ///            "id": "sea-stars-ab-1"
     ///        }
     ///    ],
     ///    "$type": "SerializableGrid"
     ///}
     ///</json>
    public static SerializableGrid presetGrid = HoodedFigure5BInstance.presetGrid;
    public static PresetGridMode presetGridMode = PresetGridMode.SILHOUETTE;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "item": {
     ///                "minSizeCentimeters": 20.0,
     ///                "maxSizeCentimeters": 40.0,
     ///                "aberrations": [],
     ///                "isAberration": true,
     ///                "nonAberrationParent": {
     ///                    "minSizeCentimeters": 20.0,
     ///                    "maxSizeCentimeters": 40.0,
     ///                    "aberrations": [
     ///                        {
     ///                            "$ref": "2"
     ///                        }
     ///                    ],
     ///                    "isAberration": false,
     ///                    "nonAberrationParent": null,
     ///                    "minWorldPhaseRequired": 0,
     ///                    "locationHiddenUntilCaught": false,
     ///                    "day": true,
     ///                    "night": true,
     ///                    "canAppearInBaitBalls": true,
     ///                    "questCompleteRequired": null,
     ///                    "baitChanceOverride": -1.0,
     ///                    "canBeInfected": true,
     ///                    "cellsExcludedFromDisplayingInfection": [],
     ///                    "rotCoefficient": 1.0,
     ///                    "tirPhase": 0,
     ///                    "harvestMinigameType": "FISHING_RADIAL",
     ///                    "perSpotMin": 3,
     ///                    "perSpotMax": 7,
     ///                    "harvestItemWeight": 4.0,
     ///                    "regenHarvestSpotOnDestroy": false,
     ///                    "harvestPOICategory": "NONE",
     ///                    "harvestableType": "CRAB",
     ///                    "requiresAdvancedEquipment": false,
     ///                    "harvestDifficulty": "EASY",
     ///                    "canBeReplacedWithResearchItem": false,
     ///                    "canBeCaughtByRod": false,
     ///                    "canBeCaughtByPot": true,
     ///                    "canBeCaughtByNet": false,
     ///                    "affectedByFishingSustain": false,
     ///                    "hasMinDepth": true,
     ///                    "minDepth": "VERY_DEEP",
     ///                    "hasMaxDepth": false,
     ///                    "maxDepth": "VERY_DEEP",
     ///                    "zonesFoundIn": "PALE_REACH,ALL",
     ///                    "canBeSoldByPlayer": true,
     ///                    "canBeSoldInBulkAction": true,
     ///                    "value": 12.0,
     ///                    "hasSellOverride": false,
     ///                    "sellOverrideValue": 0.0,
     ///                    "sprite": {
     ///
     ///                    },
     ///                    "platformSpecificSpriteOverrides": null,
     ///                    "itemColor": {
     ///                        "r": 0.2264151,
     ///                        "g": 0.1562912,
     ///                        "b": 0.1249555,
     ///                        "a": 255.0
     ///                    },
     ///                    "hasSpecialDiscardAction": false,
     ///                    "discardPromptOverride": "",
     ///                    "canBeDiscardedByPlayer": true,
     ///                    "showAlertOnDiscardHold": false,
     ///                    "discardHoldTimeOverride": false,
     ///                    "discardHoldTimeSec": 0.0,
     ///                    "canBeDiscardedDuringQuestPickup": true,
     ///                    "damageMode": "DESTROY",
     ///                    "moveMode": "FREE",
     ///                    "ignoreDamageWhenPlacing": false,
     ///                    "isUnderlayItem": false,
     ///                    "forbidStorageTray": false,
     ///                    "dimensions": [
     ///                        {
     ///
     ///                        },
     ///                        {
     ///
     ///                        }
     ///                    ],
     ///                    "squishFactor": 1.0,
     ///                    "itemOwnPrerequisites": [],
     ///                    "researchPrerequisites": [],
     ///                    "researchPointsRequired": 0,
     ///                    "buyableWithoutResearch": false,
     ///                    "researchIsForRecipe": false,
     ///                    "useIntenseAberratedUIShader": false,
     ///                    "id": "sea-stars",
     ///                    "itemNameKey": [],
     ///                    "itemDescriptionKey": [],
     ///                    "hasAdditionalNote": false,
     ///                    "additionalNoteKey": [],
     ///                    "itemInsaneTitleKey": [],
     ///                    "itemInsaneDescriptionKey": [],
     ///                    "linkedDialogueNode": "",
     ///                    "dialogueNodeSpecificDescription": [],
     ///                    "itemType": "GENERAL,ALL",
     ///                    "itemSubtype": "FISH,ALL",
     ///                    "tooltipTextColor": {
     ///                        "r": 0.4901961,
     ///                        "g": 0.3843137,
     ///                        "b": 0.2666667,
     ///                        "a": 1.0
     ///                    },
     ///                    "tooltipNotesColor": {
     ///                        "r": 1.0,
     ///                        "g": 1.0,
     ///                        "b": 1.0,
     ///                        "a": 1.0
     ///                    },
     ///                    "itemTypeIcon": {
     ///                        "$id": "17"
     ///                    },
     ///                    "harvestParticlePrefab": {
     ///                        "$id": "18"
     ///                    },
     ///                    "overrideHarvestParticleDepth": false,
     ///                    "harvestParticleDepthOffset": -3.0,
     ///                    "flattenParticleShape": false,
     ///                    "availableInDemo": false,
     ///                    "entitlementsRequired": [
     ///                        "DLC_1"
     ///                    ]
     ///                },
     ///                "minWorldPhaseRequired": 1,
     ///                "locationHiddenUntilCaught": false,
     ///                "day": true,
     ///                "night": true,
     ///                "canAppearInBaitBalls": true,
     ///                "questCompleteRequired": null,
     ///                "baitChanceOverride": -1.0,
     ///                "canBeInfected": true,
     ///                "cellsExcludedFromDisplayingInfection": [],
     ///                "rotCoefficient": 1.0,
     ///                "tirPhase": 0,
     ///                "harvestMinigameType": "FISHING_RADIAL",
     ///                "perSpotMin": 3,
     ///                "perSpotMax": 7,
     ///                "harvestItemWeight": 4.0,
     ///                "regenHarvestSpotOnDestroy": false,
     ///                "harvestPOICategory": "NONE",
     ///                "harvestableType": "CRAB",
     ///                "requiresAdvancedEquipment": false,
     ///                "harvestDifficulty": "EASY",
     ///                "canBeReplacedWithResearchItem": false,
     ///                "canBeCaughtByRod": false,
     ///                "canBeCaughtByPot": true,
     ///                "canBeCaughtByNet": false,
     ///                "affectedByFishingSustain": false,
     ///                "hasMinDepth": true,
     ///                "minDepth": "VERY_DEEP",
     ///                "hasMaxDepth": false,
     ///                "maxDepth": "VERY_DEEP",
     ///                "zonesFoundIn": "PALE_REACH,ALL",
     ///                "canBeSoldByPlayer": true,
     ///                "canBeSoldInBulkAction": true,
     ///                "value": 40.0,
     ///                "hasSellOverride": false,
     ///                "sellOverrideValue": 0.0,
     ///                "sprite": {
     ///
     ///                },
     ///                "platformSpecificSpriteOverrides": null,
     ///                "itemColor": {
     ///                    "r": 0.5333334,
     ///                    "g": 0.0,
     ///                    "b": 0.2980392,
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
     ///                    }
     ///                ],
     ///                "squishFactor": 1.0,
     ///                "itemOwnPrerequisites": [],
     ///                "researchPrerequisites": [],
     ///                "researchPointsRequired": 0,
     ///                "buyableWithoutResearch": false,
     ///                "researchIsForRecipe": false,
     ///                "useIntenseAberratedUIShader": false,
     ///                "id": "sea-stars-ab-1",
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
     ///                    "r": 0.5333334,
     ///                    "g": 0.0,
     ///                    "b": 0.2980392,
     ///                    "a": 1.0
     ///                },
     ///                "tooltipNotesColor": {
     ///                    "r": 1.0,
     ///                    "g": 1.0,
     ///                    "b": 1.0,
     ///                    "a": 1.0
     ///                },
     ///                "itemTypeIcon": {
     ///                    "$ref": "17"
     ///                },
     ///                "harvestParticlePrefab": {
     ///                    "$ref": "18"
     ///                },
     ///                "overrideHarvestParticleDepth": false,
     ///                "harvestParticleDepthOffset": -3.0,
     ///                "flattenParticleShape": false,
     ///                "availableInDemo": false,
     ///                "entitlementsRequired": [
     ///                    "DLC_1"
     ///                ],
     ///                "$type": "FishItemData",
     ///                "$id": "2"
     ///            },
     ///            "count": 1,
     ///            "allowLinkedAberrations": false,
     ///            "$type": "ItemCountCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[CompletedGridCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CompletedGridCondition> completeConditions = HoodedFigure5BInstance.completeConditions;
}
