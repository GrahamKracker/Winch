namespace Winch.Api.Generators.GameReferences.GridConfigurations;
public static class ShrineAberrationReward
{
    public static GridConfiguration ShrineAberrationRewardInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "ShrineAberrationReward");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = ShrineAberrationRewardInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL | ItemType.EQUIPMENT;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.ROD;
     ///<json>
     /// {
     ///    "fishingSpeedModifier": 0.25,
     ///    "harvestableTypes": [
     ///        "OCEANIC",
     ///        "MANGROVE",
     ///        "SHALLOW"
     ///    ],
     ///    "isAdvancedEquipment": false,
     ///    "aberrationBonus": 0.025,
     ///    "canBeSoldByPlayer": true,
     ///    "canBeSoldInBulkAction": false,
     ///    "value": 180.0,
     ///    "hasSellOverride": false,
     ///    "sellOverrideValue": 0.0,
     ///    "sprite": {
     ///
     ///    },
     ///    "platformSpecificSpriteOverrides": null,
     ///    "itemColor": {
     ///        "r": 0.1921569,
     ///        "g": 0.1921569,
     ///        "b": 0.1921569,
     ///        "a": 255.0
     ///    },
     ///    "hasSpecialDiscardAction": false,
     ///    "discardPromptOverride": "",
     ///    "canBeDiscardedByPlayer": true,
     ///    "showAlertOnDiscardHold": true,
     ///    "discardHoldTimeOverride": true,
     ///    "discardHoldTimeSec": 2.0,
     ///    "canBeDiscardedDuringQuestPickup": true,
     ///    "damageMode": "OPERATION",
     ///    "moveMode": "INSTALL",
     ///    "ignoreDamageWhenPlacing": true,
     ///    "isUnderlayItem": false,
     ///    "forbidStorageTray": false,
     ///    "dimensions": [
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
     ///    "squishFactor": 0.0,
     ///    "itemOwnPrerequisites": [],
     ///    "researchPrerequisites": [],
     ///    "researchPointsRequired": 0,
     ///    "buyableWithoutResearch": false,
     ///    "researchIsForRecipe": false,
     ///    "useIntenseAberratedUIShader": false,
     ///    "id": "rod16",
     ///    "itemNameKey": [],
     ///    "itemDescriptionKey": [],
     ///    "hasAdditionalNote": false,
     ///    "additionalNoteKey": [],
     ///    "itemInsaneTitleKey": [],
     ///    "itemInsaneDescriptionKey": [],
     ///    "linkedDialogueNode": "",
     ///    "dialogueNodeSpecificDescription": [],
     ///    "itemType": "EQUIPMENT,ALL",
     ///    "itemSubtype": "ROD,ALL",
     ///    "tooltipTextColor": {
     ///        "r": 0.5333334,
     ///        "g": 0.0,
     ///        "b": 0.2980392,
     ///        "a": 1.0
     ///    },
     ///    "tooltipNotesColor": {
     ///        "r": 1.0,
     ///        "g": 1.0,
     ///        "b": 1.0,
     ///        "a": 1.0
     ///    },
     ///    "itemTypeIcon": {
     ///
     ///    },
     ///    "harvestParticlePrefab": null,
     ///    "overrideHarvestParticleDepth": false,
     ///    "harvestParticleDepthOffset": -3.0,
     ///    "flattenParticleShape": false,
     ///    "availableInDemo": false,
     ///    "entitlementsRequired": [
     ///        "NONE"
     ///    ],
     ///    "$type": "RodItemData"
     ///}
     ///</json>
    public static ItemData mainItemData = ShrineAberrationRewardInstance.mainItemData;
    public static bool itemsInThisBelongToPlayer = false;
    public static bool canAddItemsInQuestMode = true;
    public static bool hasUnderlay = false;
    public static int columns = 2;
    public static int rows = 3;
}
