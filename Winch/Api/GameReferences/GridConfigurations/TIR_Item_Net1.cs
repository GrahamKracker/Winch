namespace Winch.Api.Generators.GameReferences.GridConfigurations;
public static class TIR_Item_Net1
{
    public static GridConfiguration TIR_Item_Net1Instance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "TIR_Item_Net1");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = TIR_Item_Net1Instance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL | ItemType.EQUIPMENT;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.GENERAL | ItemSubtype.MATERIAL | ItemSubtype.NET;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = false;
    public static bool canAddItemsInQuestMode = true;
    public static bool hasUnderlay = false;
    public static int columns = 4;
    public static int rows = 2;
}
