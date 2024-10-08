﻿using System.Collections.Generic;

namespace Winch.Serialization.Item;

// Can't really see a use for this but putting it here anyway.
public class DamageItemDataConverter : SpatialItemDataConverter
{
    private readonly Dictionary<string, FieldDefinition> _definitions = new()
    {
        { "id", new("dmg", null) },
        { "canBeDiscardedByPlayer", new(false, null) },
        { "forbidStorageTray", new(true, null) },
        { "itemType", new(ItemType.DAMAGE , null) },
        { "itemSubtype", new(ItemSubtype.NONE, null) }
    };

    public DamageItemDataConverter()
    {
        AddDefinitions(_definitions);
    }
}