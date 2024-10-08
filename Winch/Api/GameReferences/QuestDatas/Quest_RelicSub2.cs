namespace Winch.Api.Generators.GameReferences.QuestDatas;
public static class Quest_RelicSub2
{
    public static QuestData Quest_RelicSub2Instance = (QuestData)System.Linq.Enumerable.First(ScriptableObjectInstances.QuestDatas, x => x.name == "Quest_RelicSub2");
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString titleKey = Quest_RelicSub2Instance.titleKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString summaryKey = Quest_RelicSub2Instance.summaryKey;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "UnityEngine.Localization.LocalizedString[]"
     ///}
     ///</json>
    public static UnityEngine.Localization.LocalizedString[] resolutionKeys = Quest_RelicSub2Instance.resolutionKeys;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[MapMarkerData, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<MapMarkerData> mapMarkersToRemoveOnCompletion = Quest_RelicSub2Instance.mapMarkersToRemoveOnCompletion;
    public static bool showUnseenIndicators = false;
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "mapMarkersToAddOnStart": [],
     ///            "mapMarkersToDeleteOnCompletion": [
     ///                {
     ///                    "x": 411.05,
     ///                    "z": -463.04,
     ///                    "mapMarkerType": "MAIN",
     ///                    "$id": "4"
     ///                }
     ///            ],
     ///            "hiddenWhenActive": false,
     ///            "hiddenWhenComplete": true,
     ///            "shortActiveKey": [],
     ///            "longActiveKey": [],
     ///            "completedKey": [],
     ///            "hideIfThisStepIsComplete": null,
     ///            "showAtDock": false,
     ///            "stepDock": null,
     ///            "showAtSpeaker": false,
     ///            "stepSpeaker": null,
     ///            "yarnRootNode": "",
     ///            "showConditions": [],
     ///            "canBeFailed": false,
     ///            "failureEvents": [],
     ///            "allowAutomaticCompletion": true,
     ///            "conditionMode": "ALL",
     ///            "completeConditions": [
     ///                {
     ///                    "itemId": "relic2",
     ///                    "silent": false,
     ///                    "$type": "ItemInventoryCondition"
     ///                }
     ///            ]
     ///        },
     ///        {
     ///            "mapMarkersToAddOnStart": [],
     ///            "mapMarkersToDeleteOnCompletion": [
     ///                {
     ///                    "$ref": "4"
     ///                }
     ///            ],
     ///            "hiddenWhenActive": false,
     ///            "hiddenWhenComplete": false,
     ///            "shortActiveKey": [],
     ///            "longActiveKey": [],
     ///            "completedKey": [],
     ///            "hideIfThisStepIsComplete": {
     ///                "mapMarkersToAddOnStart": [],
     ///                "mapMarkersToDeleteOnCompletion": [],
     ///                "hiddenWhenActive": true,
     ///                "hiddenWhenComplete": false,
     ///                "shortActiveKey": [],
     ///                "longActiveKey": [],
     ///                "completedKey": [],
     ///                "hideIfThisStepIsComplete": null,
     ///                "showAtDock": false,
     ///                "stepDock": null,
     ///                "showAtSpeaker": false,
     ///                "stepSpeaker": null,
     ///                "yarnRootNode": "",
     ///                "showConditions": [],
     ///                "canBeFailed": false,
     ///                "failureEvents": [],
     ///                "allowAutomaticCompletion": true,
     ///                "conditionMode": "ALL",
     ///                "completeConditions": [
     ///                    {
     ///                        "quest": {
     ///                            "titleKey": [],
     ///                            "summaryKey": [],
     ///                            "resolutionKeys": [],
     ///                            "mapMarkersToRemoveOnCompletion": [],
     ///                            "showUnseenIndicators": false,
     ///                            "steps": [
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "x": -76.35,
     ///                                            "z": -52.7,
     ///                                            "mapMarkerType": "MAIN",
     ///                                            "$id": "36"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": true,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": null,
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": true,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": [
     ///                                        {
     ///                                            "itemId": "relic1",
     ///                                            "silent": false,
     ///                                            "$type": "ItemInventoryCondition"
     ///                                        }
     ///                                    ]
     ///                                },
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "$ref": "36"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": false,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": {
     ///                                        "$ref": "18"
     ///                                    },
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": false,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": []
     ///                                }
     ///                            ],
     ///                            "subquests": [],
     ///                            "onOfferedQuestStep": null,
     ///                            "canBeOfferedAutomatically": false,
     ///                            "offerConditions": [],
     ///                            "PS5Subtask": "Task_Chapter1"
     ///                        },
     ///                        "state": "COMPLETED",
     ///                        "silent": false,
     ///                        "$type": "OtherQuestCondition"
     ///                    },
     ///                    {
     ///                        "quest": {
     ///                            "titleKey": [],
     ///                            "summaryKey": [],
     ///                            "resolutionKeys": [],
     ///                            "mapMarkersToRemoveOnCompletion": [],
     ///                            "showUnseenIndicators": false,
     ///                            "steps": {
     ///                                "$ref": "0"
     ///                            },
     ///                            "subquests": [],
     ///                            "onOfferedQuestStep": null,
     ///                            "canBeOfferedAutomatically": false,
     ///                            "offerConditions": [],
     ///                            "PS5Subtask": "Task_Chapter2"
     ///                        },
     ///                        "state": "COMPLETED",
     ///                        "silent": false,
     ///                        "$type": "OtherQuestCondition"
     ///                    },
     ///                    {
     ///                        "quest": {
     ///                            "titleKey": [],
     ///                            "summaryKey": [],
     ///                            "resolutionKeys": [],
     ///                            "mapMarkersToRemoveOnCompletion": [],
     ///                            "showUnseenIndicators": false,
     ///                            "steps": [
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "x": -431.6,
     ///                                            "z": -456.7,
     ///                                            "mapMarkerType": "MAIN",
     ///                                            "$id": "71"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": true,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": null,
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": true,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": [
     ///                                        {
     ///                                            "itemId": "relic3",
     ///                                            "silent": false,
     ///                                            "$type": "ItemInventoryCondition"
     ///                                        }
     ///                                    ]
     ///                                },
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "$ref": "71"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": false,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": {
     ///                                        "$ref": "18"
     ///                                    },
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": false,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": []
     ///                                }
     ///                            ],
     ///                            "subquests": [],
     ///                            "onOfferedQuestStep": null,
     ///                            "canBeOfferedAutomatically": false,
     ///                            "offerConditions": [],
     ///                            "PS5Subtask": "Task_Chapter3"
     ///                        },
     ///                        "state": "COMPLETED",
     ///                        "silent": false,
     ///                        "$type": "OtherQuestCondition"
     ///                    },
     ///                    {
     ///                        "quest": {
     ///                            "titleKey": [],
     ///                            "summaryKey": [],
     ///                            "resolutionKeys": [],
     ///                            "mapMarkersToRemoveOnCompletion": [],
     ///                            "showUnseenIndicators": false,
     ///                            "steps": [
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "x": -464.24,
     ///                                            "z": 530.35,
     ///                                            "mapMarkerType": "MAIN",
     ///                                            "$id": "99"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": true,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": null,
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": true,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": [
     ///                                        {
     ///                                            "itemId": "relic4",
     ///                                            "silent": false,
     ///                                            "$type": "ItemInventoryCondition"
     ///                                        }
     ///                                    ]
     ///                                },
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "$ref": "99"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": false,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": {
     ///                                        "$ref": "18"
     ///                                    },
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": false,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": []
     ///                                }
     ///                            ],
     ///                            "subquests": [],
     ///                            "onOfferedQuestStep": null,
     ///                            "canBeOfferedAutomatically": false,
     ///                            "offerConditions": [],
     ///                            "PS5Subtask": "Task_Chapter4"
     ///                        },
     ///                        "state": "COMPLETED",
     ///                        "silent": false,
     ///                        "$type": "OtherQuestCondition"
     ///                    },
     ///                    {
     ///                        "quest": {
     ///                            "titleKey": [],
     ///                            "summaryKey": [],
     ///                            "resolutionKeys": [],
     ///                            "mapMarkersToRemoveOnCompletion": [],
     ///                            "showUnseenIndicators": false,
     ///                            "steps": [
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "x": 454.3544,
     ///                                            "z": 451.7758,
     ///                                            "mapMarkerType": "MAIN",
     ///                                            "$id": "127"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": true,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": null,
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": true,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": [
     ///                                        {
     ///                                            "itemId": "relic5",
     ///                                            "silent": false,
     ///                                            "$type": "ItemInventoryCondition"
     ///                                        }
     ///                                    ]
     ///                                },
     ///                                {
     ///                                    "mapMarkersToAddOnStart": [],
     ///                                    "mapMarkersToDeleteOnCompletion": [
     ///                                        {
     ///                                            "$ref": "127"
     ///                                        }
     ///                                    ],
     ///                                    "hiddenWhenActive": false,
     ///                                    "hiddenWhenComplete": false,
     ///                                    "shortActiveKey": [],
     ///                                    "longActiveKey": [],
     ///                                    "completedKey": [],
     ///                                    "hideIfThisStepIsComplete": {
     ///                                        "$ref": "18"
     ///                                    },
     ///                                    "showAtDock": false,
     ///                                    "stepDock": null,
     ///                                    "showAtSpeaker": false,
     ///                                    "stepSpeaker": null,
     ///                                    "yarnRootNode": "",
     ///                                    "showConditions": [],
     ///                                    "canBeFailed": false,
     ///                                    "failureEvents": [],
     ///                                    "allowAutomaticCompletion": false,
     ///                                    "conditionMode": "ALL",
     ///                                    "completeConditions": []
     ///                                }
     ///                            ],
     ///                            "subquests": [],
     ///                            "onOfferedQuestStep": null,
     ///                            "canBeOfferedAutomatically": false,
     ///                            "offerConditions": [],
     ///                            "PS5Subtask": "Task_Chapter5"
     ///                        },
     ///                        "state": "COMPLETED",
     ///                        "silent": false,
     ///                        "$type": "OtherQuestCondition"
     ///                    }
     ///                ],
     ///                "$id": "18"
     ///            },
     ///            "showAtDock": false,
     ///            "stepDock": null,
     ///            "showAtSpeaker": false,
     ///            "stepSpeaker": null,
     ///            "yarnRootNode": "",
     ///            "showConditions": [],
     ///            "canBeFailed": false,
     ///            "failureEvents": [],
     ///            "allowAutomaticCompletion": false,
     ///            "conditionMode": "ALL",
     ///            "completeConditions": []
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[QuestStepData, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]",
     ///    "$id": "0"
     ///}
     ///</json>
    public static System.Collections.Generic.List<QuestStepData> steps = Quest_RelicSub2Instance.steps;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[QuestData, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<QuestData> subquests = Quest_RelicSub2Instance.subquests;
     ///<json>
     /// null
     /// </json>
    public static QuestStepData onOfferedQuestStep = null;
    public static bool canBeOfferedAutomatically = false;
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[QuestStepCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<QuestStepCondition> offerConditions = Quest_RelicSub2Instance.offerConditions;
    public static string PS5Subtask = "";
}
