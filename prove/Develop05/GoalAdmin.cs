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
    

    
    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput;

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplished?  ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\nYou have {GetTotalPoints()} points.\n");
    }
    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nMy Goals are:");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nNo goals found.");
        }
    }
    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput;

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            readText = readText.Skip(1).ToArray();
            foreach (string line in readText)
            {
                string[] entries = line.Split("| ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(simpleGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eternalGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eternalGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(checklistGoal);
                }
            }
        }
    }


}