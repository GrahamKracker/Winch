namespace Winch.Api.GameReferences.AchievementDatas;
public static class ABILITY_ATROPHY
{
    public static AchievementData ABILITY_ATROPHYInstance = (AchievementData)System.Linq.Enumerable.First(ScriptableObjectInstances.AchievementDatas, x => x.name == "ABILITY_ATROPHY");
    public static DredgeAchievementId id = DredgeAchievementId.ABILITY_ATROPHY;
    public static string steamId = "";
    public static int playStationId = 18;
    public static string xboxId = "";
     ///<json>
     /// {
     ///    "$content": [],
     ///    "$type": "System.Collections.Generic.List`1[[AchievementCondition, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]"
     ///}
     ///</json>
    public static System.Collections.Generic.List<AchievementCondition> evaluationConditions = ABILITY_ATROPHYInstance.evaluationConditions;
}
