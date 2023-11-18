using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        GoalAdministration goals = new GoalAdministration();

        Console.Clear();
        Console.Write("\nWelcome to the Eternal Quest Program\n");

        Console.Write($"\nYou have {goals.GetTotalPoints()} points.\n");
        MainMenu choice = new MainMenu();
        GoalMenu goalChoice = new GoalMenu();


        int action = 0;
        while (action != 6)
        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    Console.Clear(); 
                    int goalInput = 0;
                    while (goalInput != 4)
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                Console.Write("What is the name of your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.Write("What is the description of it?  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How points are associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal simpleGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(simpleGoal);
                                goalInput = 4;
                                break;
                            case 2:
                                Console.Write("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.Write("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eternalGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eternalGoal);
                                goalInput = 4;
                                break;
                            case 3:
                                Console.Write("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.Write("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal checklistGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(checklistGoal);
                                goalInput = 4;
                                break;
                            default:
                                Console.WriteLine($"\nInvalid Response.");
                                break;
                        }
                    }
                    break;
                case 2:
                    goals.ListGoals();
                    Console.Write($"\nYou have {goals.GetTotalPoints()} points.\n");
                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    Console.Clear();
                    goals.LoadGoals();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write($"\nYou currently have {goals.GetTotalPoints()} points.\n");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nInvalid Response..");
                    break;
            }
        }
    }
}