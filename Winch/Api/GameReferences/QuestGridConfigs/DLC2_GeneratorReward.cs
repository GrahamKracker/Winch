namespace Winch.Api.GameReferences.QuestGridConfigs;
public static class DLC2_GeneratorReward
{
    public static QuestGridConfig DLC2_GeneratorRewardInstance = (QuestGridConfig)System.Linq.Enumerable.First(ScriptableObjectInstances.QuestGridConfigs, x => x.name == "DLC2_GeneratorReward");
    public static QuestGridExitMode questGridExitMode = QuestGridExitMode.RISK_ITEM_LOSS;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString titleString = DLC2_GeneratorRewardInstance.titleString;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString helpStringOverride = DLC2_GeneratorRewardInstance.helpStringOverride;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString exitPromptOverride = DLC2_GeneratorRewardInstance.exitPromptOverride;
     ///<json>
     /// null
     /// </json>
    public static UnityEngine.Sprite backgroundImage = null;
    public static float gridHeightOverride = 0f;
    public static bool overrideGridCellColor = false;
    public static DredgeColorTypeEnum gridCellColor = DredgeColorTypeEnum.NEUTRAL;
    public static bool allowStorageAccess = true;
    public static bool isSaved = false;
    public static bool createItemsIfEmpty = true;
    public static GridKey gridKey = GridKey.NONE;
    public static bool allowManualExit = true;
    public static bool allowEquipmentInstallation = true;
    public static bool createWithDurabilityValue = false;
    public static float startingDurabilityProportion = 1f;
     ///<json>
     /// {
     ///    "cellGroupConfigs": [],
     ///    "mainItemType": "GENERAL,ALL",
     ///    "mainItemSubtype": "FISH,ENGINE,ROD,GENERAL,RELIC,TRINKET,MATERIAL,LIGHT,POT,NET,DREDGE,GADGET,ALL",
     ///    "mainItemData": null,
     ///    "itemsInThisBelongToPlayer": false,
     ///    "canAddItemsInQuestMode": false,
     ///    "hasUnderlay": false,
     ///    "columns": 1,
     ///    "rows": 1,
     ///    "$type": "GridConfiguration"
     ///}
     ///</json>
    public static GridConfiguration gridConfiguration = DLC2_GeneratorRewardInstance.gridConfiguration;
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
     ///            "id": "repair-boat"
     ///        }
     ///    ],
     ///    "$type": "SerializableGrid"
     ///}
     ///</json>
    public static SerializableGrid presetGrid = DLC2_GeneratorRewardInstance.presetGrid;
    public static PresetGridMode presetGridMode = PresetGridMode.CREATE;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "$type": "EmptyCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[CompletedGridCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CompletedGridCondition> completeConditions = DLC2_GeneratorRewardInstance.completeConditions;
}
