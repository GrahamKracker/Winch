namespace Winch.Api.Generators.GameReferences.GridConfigurations;
public static class TIR_Product_FleetServices
{
    public static GridConfiguration TIR_Product_FleetServicesInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "TIR_Product_FleetServices");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = TIR_Product_FleetServicesInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL | ItemType.EQUIPMENT | ItemType.DAMAGE | ItemType.ALL;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.FISH | ItemSubtype.ENGINE | ItemSubtype.ROD | ItemSubtype.GENERAL | ItemSubtype.RELIC | ItemSubtype.TRINKET | ItemSubtype.MATERIAL | ItemSubtype.LIGHT | ItemSubtype.POT | ItemSubtype.NET | ItemSubtype.DREDGE | ItemSubtype.GADGET | ItemSubtype.ALL;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = true;
    public static bool canAddItemsInQuestMode = false;
    public static bool hasUnderlay = false;
    public static int columns = 4;
    public static int rows = 4;
}
