namespace Winch.Api.Generators.GameReferences.QuestGridConfigs;
public static class TIR_Building_FactoryTier4
{
    public static QuestGridConfig TIR_Building_FactoryTier4Instance = (QuestGridConfig)System.Linq.Enumerable.First(ScriptableObjectInstances.QuestGridConfigs, x => x.name == "TIR_Building_FactoryTier4");
    public static QuestGridExitMode questGridExitMode = QuestGridExitMode.REVISITABLE;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString titleString = TIR_Building_FactoryTier4Instance.titleString;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString helpStringOverride = TIR_Building_FactoryTier4Instance.helpStringOverride;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString exitPromptOverride = TIR_Building_FactoryTier4Instance.exitPromptOverride;
     ///<json>
     /// null
     /// </json>
    public static UnityEngine.Sprite backgroundImage = null;
    public static float gridHeightOverride = 0f;
    public static bool overrideGridCellColor = false;
    public static DredgeColorTypeEnum gridCellColor = DredgeColorTypeEnum.NEUTRAL;
    public static bool allowStorageAccess = false;
    public static bool isSaved = true;
    public static bool createItemsIfEmpty = false;
    public static GridKey gridKey = GridKey.TIR_FACTORY_TIER_4;
    public static bool allowManualExit = true;
    public static bool allowEquipmentInstallation = true;
    public static bool createWithDurabilityValue = false;
    public static float startingDurabilityProportion = 1f;
     ///<json>
     /// {
     ///    "cellGroupConfigs": [],
     ///    "mainItemType": "GENERAL,ALL",
     ///    "mainItemSubtype": "MATERIAL,ALL",
     ///    "mainItemData": {
     ///        "harvestMinigameType": "DREDGE_RADIAL",
     ///        "perSpotMin": 1,
     ///        "perSpotMax": 2,
     ///        "harvestItemWeight": 50.0,
     ///        "regenHarvestSpotOnDestroy": false,
     ///        "harvestPOICategory": "MATERIAL",
     ///        "harvestableType": "DREDGE",
     ///        "requiresAdvancedEquipment": false,
     ///        "harvestDifficulty": "MEDIUM",
     ///        "canBeReplacedWithResearchItem": false,
     ///        "canBeCaughtByRod": false,
     ///        "canBeCaughtByPot": false,
     ///        "canBeCaughtByNet": false,
     ///        "affectedByFishingSustain": false,
     ///        "hasMinDepth": false,
     ///        "minDepth": "VERY_SHALLOW",
     ///        "hasMaxDepth": false,
     ///        "maxDepth": "VERY_SHALLOW",
     ///        "zonesFoundIn": "THE_MARROWS,GALE_CLIFFS,STELLAR_BASIN,TWISTED_STRAND,DEVILS_SPINE,OPEN_OCEAN,PALE_REACH,ALL",
     ///        "canBeSoldByPlayer": false,
     ///        "canBeSoldInBulkAction": false,
     ///        "value": 0.0,
     ///        "hasSellOverride": false,
     ///        "sellOverrideValue": 0.0,
     ///        "sprite": {
     ///
     ///        },
     ///        "platformSpecificSpriteOverrides": null,
     ///        "itemColor": {
     ///            "r": 0.227451,
     ///            "g": 0.1568628,
     ///            "b": 0.1254902,
     ///            "a": 1.0
     ///        },
     ///        "hasSpecialDiscardAction": false,
     ///        "discardPromptOverride": "",
     ///        "canBeDiscardedByPlayer": true,
     ///        "showAlertOnDiscardHold": false,
     ///        "discardHoldTimeOverride": true,
     ///        "discardHoldTimeSec": 3.0,
     ///        "canBeDiscardedDuringQuestPickup": true,
     ///        "damageMode": "DESTROY",
     ///        "moveMode": "FREE",
     ///        "ignoreDamageWhenPlacing": false,
     ///        "isUnderlayItem": false,
     ///        "forbidStorageTray": false,
     ///        "dimensions": [
     ///            {
     ///
     ///            },
     ///            {
     ///
     ///            },
     ///            {
     ///
     ///            },
     ///            {
     ///
     ///            }
     ///        ],
     ///        "squishFactor": 0.0,
     ///        "itemOwnPrerequisites": [],
     ///        "researchPrerequisites": [],
     ///        "researchPointsRequired": 0,
     ///        "buyableWithoutResearch": false,
     ///        "researchIsForRecipe": false,
     ///        "useIntenseAberratedUIShader": false,
     ///        "id": "crate",
     ///        "itemNameKey": [],
     ///        "itemDescriptionKey": [],
     ///        "hasAdditionalNote": true,
     ///        "additionalNoteKey": [],
     ///        "itemInsaneTitleKey": [],
     ///        "itemInsaneDescriptionKey": [],
     ///        "linkedDialogueNode": "",
     ///        "dialogueNodeSpecificDescription": [],
     ///        "itemType": "GENERAL,ALL",
     ///        "itemSubtype": "MATERIAL,ALL",
     ///        "tooltipTextColor": {
     ///            "r": 0.4901961,
     ///            "g": 0.3843137,
     ///            "b": 0.2666667,
     ///            "a": 1.0
     ///        },
     ///        "tooltipNotesColor": {
     ///            "r": 1.0,
     ///            "g": 1.0,
     ///            "b": 1.0,
     ///            "a": 1.0
     ///        },
     ///        "itemTypeIcon": {
     ///
     ///        },
     ///        "harvestParticlePrefab": {
     ///
     ///        },
     ///        "overrideHarvestParticleDepth": false,
     ///        "harvestParticleDepthOffset": -3.0,
     ///        "flattenParticleShape": false,
     ///        "availableInDemo": false,
     ///        "entitlementsRequired": [
     ///            "DLC_2"
     ///        ],
     ///        "$type": "HarvestableItemData"
     ///    },
     ///    "itemsInThisBelongToPlayer": false,
     ///    "canAddItemsInQuestMode": true,
     ///    "hasUnderlay": false,
     ///    "columns": 4,
     ///    "rows": 2,
     ///    "$type": "GridConfiguration"
     ///}
     ///</json>
    public static GridConfiguration gridConfiguration = TIR_Building_FactoryTier4Instance.gridConfiguration;
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
     ///            "id": "crate"
     ///        },
     ///        {
     ///            "x": 2,
     ///            "y": 0,
     ///            "z": 0,
     ///            "durability": 0.0,
     ///            "seen": false,
     ///            "id": "crate"
     ///        }
     ///    ],
     ///    "$type": "SerializableGrid"
     ///}
     ///</json>
    public static SerializableGrid presetGrid = TIR_Building_FactoryTier4Instance.presetGrid;
    public static PresetGridMode presetGridMode = PresetGridMode.SILHOUETTE;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "item": {
     ///                "harvestMinigameType": "DREDGE_RADIAL",
     ///                "perSpotMin": 1,
     ///                "perSpotMax": 2,
     ///                "harvestItemWeight": 50.0,
     ///                "regenHarvestSpotOnDestroy": false,
     ///                "harvestPOICategory": "MATERIAL",
     ///                "harvestableType": "DREDGE",
     ///                "requiresAdvancedEquipment": false,
     ///                "harvestDifficulty": "MEDIUM",
     ///                "canBeReplacedWithResearchItem": false,
     ///                "canBeCaughtByRod": false,
     ///                "canBeCaughtByPot": false,
     ///                "canBeCaughtByNet": false,
     ///                "affectedByFishingSustain": false,
     ///                "hasMinDepth": false,
     ///                "minDepth": "VERY_SHALLOW",
     ///                "hasMaxDepth": false,
     ///                "maxDepth": "VERY_SHALLOW",
     ///                "zonesFoundIn": "THE_MARROWS,GALE_CLIFFS,STELLAR_BASIN,TWISTED_STRAND,DEVILS_SPINE,OPEN_OCEAN,PALE_REACH,ALL",
     ///                "canBeSoldByPlayer": false,
     ///                "canBeSoldInBulkAction": false,
     ///                "value": 0.0,
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
     ///                "discardHoldTimeOverride": true,
     ///                "discardHoldTimeSec": 3.0,
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
     ///                    }
     ///                ],
     ///                "squishFactor": 0.0,
     ///                "itemOwnPrerequisites": [],
     ///                "researchPrerequisites": [],
     ///                "researchPointsRequired": 0,
     ///                "buyableWithoutResearch": false,
     ///                "researchIsForRecipe": false,
     ///                "useIntenseAberratedUIShader": false,
     ///                "id": "crate",
     ///                "itemNameKey": [],
     ///                "itemDescriptionKey": [],
     ///                "hasAdditionalNote": true,
     ///                "additionalNoteKey": [],
     ///                "itemInsaneTitleKey": [],
     ///                "itemInsaneDescriptionKey": [],
     ///                "linkedDialogueNode": "",
     ///                "dialogueNodeSpecificDescription": [],
     ///                "itemType": "GENERAL,ALL",
     ///                "itemSubtype": "MATERIAL,ALL",
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
     ///
     ///                },
     ///                "harvestParticlePrefab": {
     ///
     ///                },
     ///                "overrideHarvestParticleDepth": false,
     ///                "harvestParticleDepthOffset": -3.0,
     ///                "flattenParticleShape": false,
     ///                "availableInDemo": false,
     ///                "entitlementsRequired": [
     ///                    "DLC_2"
     ///                ],
     ///                "$type": "HarvestableItemData"
     ///            },
     ///            "count": 2,
     ///            "allowLinkedAberrations": false,
     ///            "$type": "ItemCountCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[CompletedGridCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CompletedGridCondition> completeConditions = TIR_Building_FactoryTier4Instance.completeConditions;
}
