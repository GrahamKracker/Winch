namespace Winch.Api.GameReferences.QuestGridConfigs;
public static class TIR_Product_Foundry
{
    public static QuestGridConfig TIR_Product_FoundryInstance = (QuestGridConfig)System.Linq.Enumerable.First(ScriptableObjectInstances.QuestGridConfigs, x => x.name == "TIR_Product_Foundry");
    public static QuestGridExitMode questGridExitMode = QuestGridExitMode.REVISITABLE;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString titleString = TIR_Product_FoundryInstance.titleString;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString helpStringOverride = TIR_Product_FoundryInstance.helpStringOverride;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString exitPromptOverride = TIR_Product_FoundryInstance.exitPromptOverride;
     ///<json>
     /// null
     /// </json>
    public static UnityEngine.Sprite backgroundImage = null;
    public static float gridHeightOverride = 0f;
    public static bool overrideGridCellColor = false;
    public static DredgeColorTypeEnum gridCellColor = DredgeColorTypeEnum.NEUTRAL;
    public static bool allowStorageAccess = true;
    public static bool isSaved = true;
    public static bool createItemsIfEmpty = false;
    public static GridKey gridKey = GridKey.TIR_FOUNDRY_PRODUCT;
    public static bool allowManualExit = true;
    public static bool allowEquipmentInstallation = true;
    public static bool createWithDurabilityValue = false;
    public static float startingDurabilityProportion = 1f;
     ///<json>
     /// {
     ///    "cellGroupConfigs": [],
     ///    "mainItemType": "GENERAL,EQUIPMENT,DAMAGE,ALL",
     ///    "mainItemSubtype": "FISH,ENGINE,ROD,GENERAL,RELIC,TRINKET,MATERIAL,LIGHT,POT,NET,DREDGE,GADGET,ALL",
     ///    "mainItemData": null,
     ///    "itemsInThisBelongToPlayer": true,
     ///    "canAddItemsInQuestMode": false,
     ///    "hasUnderlay": false,
     ///    "columns": 4,
     ///    "rows": 4,
     ///    "$type": "GridConfiguration"
     ///}
     ///</json>
    public static GridConfiguration gridConfiguration = TIR_Product_FoundryInstance.gridConfiguration;
     ///<json>
     /// {
     ///    "spatialUnderlayItems": [],
     ///    "spatialItems": [],
     ///    "$type": "SerializableGrid"
     ///}
     ///</json>
    public static SerializableGrid presetGrid = TIR_Product_FoundryInstance.presetGrid;
    public static PresetGridMode presetGridMode = PresetGridMode.NONE;
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
    public static System.Collections.Generic.List<CompletedGridCondition> completeConditions = TIR_Product_FoundryInstance.completeConditions;
}
