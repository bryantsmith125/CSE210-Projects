using System;

public class Activity
{
    private string _activityName;
    private int _activityTime;
    private string _message = "You may begin in...";

    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }
    
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
    }
    public int GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like your mindfulness session to be? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }
    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }
    
    
    


public void CountDown(int time)
    {
        Console.WriteLine(); 
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));
            Console.Write(blank);
        }
        Console.WriteLine($"You may begin in:                                  "); 
    }



    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        for (int i = 5; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
    }

    public void GetDone()
    {
        Console.WriteLine("\nWell done!");
        for (int i = 3; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        Console.WriteLine($"\nYou have completed another {_activityTime} seconds of the {_activityName} Activity!");
        for (int i = 3; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        Console.WriteLine("\n");
        Console.Clear();
    }




}