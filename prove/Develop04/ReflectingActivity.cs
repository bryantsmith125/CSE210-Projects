using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _useQuestionsList = new List<string>();

    private string _prompt;
    private string _question;
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<string> _promptList = new List<string>
    {
    "Think of a time when you stood up for another person.",
    "Think of a time when you did completed a difficult challenge.",
    "Think of a time when you served someone else.",
    "Think of a time when you cared more for others than yourself."
    };
    private List<string> _questionList = new List<string>
    {
    "Why did this experience mean so much to you?",
    "Are experiences like this a regular occurance for you?",
    "Where did you start?",
    "How did you feel after this experience?",
    "What did you do differently this time than from past experiences? And was it successful?",
    "What did you like the most about this experience?",
    "How could you apply what you learned from this experience more in your life?",
    "Did you learn anything new from this experience?",
    "In what ways can you make sure that you remember this experience and the feelings involved?"
    };

    public ReflectingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void ShowPrompt(int seconds)
    {
        Console.WriteLine();
        var prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider this prompt:");
        Console.WriteLine($"\n----- {prompt} -----");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            ShowQuestion(seconds);
        }
    }
    
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
    private string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_useQuestionsList.Count);
        return _useQuestionsList[index];
    }
    
    public void ShowQuestion(int seconds)
    {
        _useQuestionsList.AddRange(_questionList);
        Console.WriteLine($"\nNow think about each of the following questions as they related to this experience.");
        CountDown(5);
        Console.Clear();  
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            if (_useQuestionsList.Count != 0)
            {
                var question = GetRandomQuestion();
                Console.Write($"\n>> {question}  ");
                _useQuestionsList.Remove(question); 
            }
            for (int i = 5; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }
        timer.Stop();
    } 



    public void Stopwatch()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        timer.Stop();

    }

}