namespace Winch.Api.Generators.GameReferences.GridConfigurations;
public static class Shop_Engines
{
    public static GridConfiguration Shop_EnginesInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "Shop_Engines");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = Shop_EnginesInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.EQUIPMENT;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.ENGINE;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = false;
    public static bool canAddItemsInQuestMode = false;
    public static bool hasUnderlay = false;
    public static int columns = 8;
    public static int rows = 9;
}
