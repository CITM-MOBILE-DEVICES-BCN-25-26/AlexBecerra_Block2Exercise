using System;

public class MatchData
{
    public int Score { get; set; }
    public int EnemiesKilled { get; set; }
    public int TimePlayedInSeconds { get; set; }
}

public class PerformanceCalculator
{
    public float GetPerformance(MatchData matchData)
    {
        return matchData.Score / (float)(matchData.TimePlayedInSeconds + 1);
    }
}
    
public class Printer
{
    public string BuildSummaryText(MatchData matchData, PerformanceCalculator performanceCalculator)
    {
        return $"Score: {matchData.Score} | Kills: {matchData.EnemiesKilled} | Performance: {performanceCalculator.GetPerformance(matchData)}";
    }
}

public interface IMatchExporter
{
    void Export(MatchData data);
}

public class JsonExporter : IMatchExporter
{
    public void Export(MatchData data) 
    {
        Console.WriteLine("Exporting match summary to JSON...");
    } 
}
public class XmlExporter : IMatchExporter
{
    public void Export(MatchData data) 
    {
        Console.WriteLine("Exporting match summary to XML...");
    }  
}


