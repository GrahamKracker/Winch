namespace Winch.Api.Generators.GameReferences.GridConfigurations;
public static class Atrophy
{
    public static GridConfiguration AtrophyInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "Atrophy");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = AtrophyInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.FISH;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = true;
    public static bool canAddItemsInQuestMode = false;
    public static bool hasUnderlay = false;
    public static int columns = 6;
    public static int rows = 6;
}
