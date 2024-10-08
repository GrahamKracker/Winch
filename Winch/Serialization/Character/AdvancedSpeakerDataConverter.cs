﻿using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using Winch.Core;
using Winch.Data.Character;
using Winch.Util;

namespace Winch.Serialization.Character;

public class AdvancedSpeakerDataConverter : DredgeTypeConverter<AdvancedSpeakerData>
{
    internal const string CharacterTableDefinition = "Characters";

    private readonly Dictionary<string, FieldDefinition> _definitions = new()
    {
        { "id", new(string.Empty, null) },
        { "paralinguisticsNameKey", new(ParalinguisticsNameKey.NONE, o=> DredgeTypeHelpers.GetEnumValue<ParalinguisticsNameKey>(o)) },
        { "portraitSprite", new(TextureUtil.GetSprite("EmptyPortrait"), o=> TextureUtil.GetSprite(o.ToString())) },
        { "speakerNameKey", new(null, null) },
        { "yarnRootNode", new(null, null) },
        { "smallPortraitSprite", new(TextureUtil.GetSprite("EmptySmallPortrait"), o=> TextureUtil.GetSprite(o.ToString())) },
        { "isIndoors", new(false, o=> bool.Parse(o.ToString())) },
        { "alwaysAvailable", new(false, o=> bool.Parse(o.ToString())) },
        { "hideNameplate", new(false, o=> bool.Parse(o.ToString())) },
        { "availableInDemo", new(false, null) },
        { "speakerNameKeyOverrides", new(new List<NameKeyOverride>(), null) },
        { "portraitOverrideConditions", new(new List<PortraitOverride>(), null) },
        { "highlightConditions", new(new List<HighlightCondition>(), null) },
        { "paralinguistics", new(new Dictionary<ParalinguisticType, List<AssetReference>>(), null) },
        { "paralinguisticOverrideConditions", new(new List<ParalinguisticOverride>(), null) }
    };

    public AdvancedSpeakerDataConverter() : base()
    {
        AddDefinitions(_definitions);
    }

    protected static LocalizedString CreateLocalizedString(string value) => CreateLocalizedString(CharacterTableDefinition, value);
}