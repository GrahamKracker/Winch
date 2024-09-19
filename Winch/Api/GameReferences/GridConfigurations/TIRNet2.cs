namespace Winch.Api.Generators.GameReferences.GridConfigurations;
public static class TIRNet2
{
    public static GridConfiguration TIRNet2Instance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "TIRNet2");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = TIRNet2Instance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.GENERAL | ItemSubtype.TRINKET | ItemSubtype.MATERIAL;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = true;
    public static bool canAddItemsInQuestMode = false;
    public static bool hasUnderlay = false;
    public static int columns = 8;
    public static int rows = 8;
}
