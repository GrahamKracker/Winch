namespace Winch.Api.GameReferences.AchievementDatas;
public static class DLC_3_6
{
    public static AchievementData DLC_3_6Instance = (AchievementData)System.Linq.Enumerable.First(ScriptableObjectInstances.AchievementDatas, x => x.name == "DLC_3_6");
    public static DredgeAchievementId id = DredgeAchievementId.DLC_3_6;
    public static string steamId = "";
    public static int playStationId = 45;
    public static string xboxId = "";
     ///<json>
     /// {
     ///    "$content": [
     ///        {
     ///            "quests": [
     ///                {
     ///                    "titleKey": [],
     ///                    "summaryKey": [],
     ///                    "resolutionKeys": [
     ///                        []
     ///                    ],
     ///                    "mapMarkersToRemoveOnCompletion": [],
     ///                    "showUnseenIndicators": true,
     ///                    "steps": [
     ///                        {
     ///                            "mapMarkersToAddOnStart": [],
     ///                            "mapMarkersToDeleteOnCompletion": [],
     ///                            "hiddenWhenActive": false,
     ///                            "hiddenWhenComplete": false,
     ///                            "shortActiveKey": [],
     ///                            "longActiveKey": [],
     ///                            "completedKey": [],
     ///                            "hideIfThisStepIsComplete": null,
     ///                            "showAtDock": false,
     ///                            "stepDock": null,
     ///                            "showAtSpeaker": false,
     ///                            "stepSpeaker": null,
     ///                            "yarnRootNode": "",
     ///                            "showConditions": [],
     ///                            "canBeFailed": false,
     ///                            "failureEvents": [],
     ///                            "allowAutomaticCompletion": false,
     ///                            "conditionMode": "ALL",
     ///                            "completeConditions": []
     ///                        }
     ///                    ],
     ///                    "subquests": [],
     ///                    "onOfferedQuestStep": null,
     ///                    "canBeOfferedAutomatically": false,
     ///                    "offerConditions": [],
     ///                    "PS5Subtask": ""
     ///                }
     ///            ],
     ///            "$type": "QuestCompleteCondition"
     ///        }
     ///    ],
     ///    "$type": "System.Collections.Generic.List`1[[AchievementCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<AchievementCondition> evaluationConditions = DLC_3_6Instance.evaluationConditions;
}
