using System;
using System.Diagnostics;

public class ListingActivity : Activity
{

    private List<string> _promptList = new List<string>
    {
    "What people in your life do you appreciate?",
    "What are your personal strengths?",
    "Who are some people that you have served this week?",
    "When did you feel the Holy Ghost this last month?",
    "Who are your heroes in your life?"
    };
    private List<string> _userList = new List<string>();
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }
    public ListingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    
    public void ReturnPrompt(int seconds)
    {
        Console.WriteLine();  
        var question = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        CountDown(5);
        Timer(seconds);
    }
    public void Timer(int seconds)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write("> ");
            _userList.Add(Console.ReadLine());
        }
        timer.Stop();
        int listLength = _userList.Count;
        Console.WriteLine($"\nYou listed {listLength} items!");
    }





}