namespace Winch.Api.Generators.GameReferences.GridConfigurations;
public static class Tier2Hull
{
    public static GridConfiguration Tier2HullInstance = (GridConfiguration)System.Linq.Enumerable.First(ScriptableObjectInstances.GridConfigurations, x => x.name == "Tier2Hull");
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,ENGINE,GENERAL,RELIC,TRINKET,MATERIAL,POT,GADGET,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "",
     ///            "itemSubtype": "",
     ///            "isHidden": true,
     ///            "damageImmune": true
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,ROD,GENERAL,RELIC,TRINKET,MATERIAL,POT,GADGET,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,ROD,GENERAL,RELIC,TRINKET,MATERIAL,POT,NET,GADGET,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "EQUIPMENT,ALL",
     ///            "itemSubtype": "DREDGE,ALL",
     ///            "isHidden": true,
     ///            "damageImmune": true
     ///        },
     ///        {
     ///            "cells": [
     ///                {
     ///
     ///                },
     ///                {
     ///
     ///                }
     ///            ],
     ///            "itemType": "GENERAL,EQUIPMENT,ALL",
     ///            "itemSubtype": "FISH,GENERAL,RELIC,TRINKET,MATERIAL,LIGHT,POT,GADGET,ALL",
     ///            "isHidden": false,
     ///            "damageImmune": false
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[CellGroupConfiguration, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<CellGroupConfiguration> cellGroupConfigs = Tier2HullInstance.cellGroupConfigs;
    public static ItemType mainItemType = ItemType.NONE | ItemType.GENERAL;
    public static ItemSubtype mainItemSubtype = ItemSubtype.NONE | ItemSubtype.FISH | ItemSubtype.GENERAL | ItemSubtype.RELIC | ItemSubtype.TRINKET | ItemSubtype.MATERIAL | ItemSubtype.POT | ItemSubtype.GADGET;
     ///<json>
     /// null
     /// </json>
    public static ItemData mainItemData = null;
    public static bool itemsInThisBelongToPlayer = true;
    public static bool canAddItemsInQuestMode = false;
    public static bool hasUnderlay = true;
    public static int columns = 7;
    public static int rows = 10;
}
