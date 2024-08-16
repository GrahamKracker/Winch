﻿using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine;

// ReSharper disable HeapView.BoxingAllocation

namespace Winch.Serialization.HarvestZone;

public class CustomHarvestZoneConverter : DredgeTypeConverter<CustomHarvestZone>
{
    private readonly Dictionary<string, FieldDefinition> _definitions = new()
    {
        { "location", new( new Vector3(0, 0, -300), o=> DredgeTypeHelpers.ParseVector3(o)) },
        { "colliderType", new( CustomHarvestZone.ColliderType.SPHERE, o=> DredgeTypeHelpers.GetEnumValue<CustomHarvestZone.ColliderType>(o)) },
        { "radius", new( 200, o=> float.Parse(o.ToString())) },
        { "size", new( new Vector3(3000, 500, 3000), o=> DredgeTypeHelpers.ParseVector3(o)) },
        { "harvestableItems", new( new List<string>(), o => DredgeTypeHelpers.ParseStringList((JArray)o)) },
        { "day", new( true, o => bool.Parse(o.ToString())) },
        { "night", new( true, o => bool.Parse(o.ToString())) },
    };

    public CustomHarvestZoneConverter()
    {
        AddDefinitions(_definitions);
    }
}
