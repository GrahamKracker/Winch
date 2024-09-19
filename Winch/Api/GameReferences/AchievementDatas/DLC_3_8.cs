namespace Winch.Api.GameReferences.AchievementDatas;
public static class DLC_3_8
{
    public static AchievementData DLC_3_8Instance = (AchievementData)System.Linq.Enumerable.First(ScriptableObjectInstances.AchievementDatas, x => x.name == "DLC_3_8");
    public static DredgeAchievementId id = DredgeAchievementId.DLC_3_8;
    public static string steamId = "";
    public static int playStationId = 47;
    public static string xboxId = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[AchievementCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<AchievementCondition> evaluationConditions = DLC_3_8Instance.evaluationConditions;
}
