using System;
using System.IO;

public class GoalAdministration

{
    private int _totalPoints;
    private List<Goal> _goals = new List<Goal>();
    
    public GoalAdministration()
    {
        _totalPoints = 0;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }
    


}