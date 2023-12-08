using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("Foundation Program 4 - Polymorphism with Exercise Tracking\n");
        Console.Write("----------------------------------------------------------\n");
        Console.WriteLine("(Polymorphism:  The ability to take on many forms.)\n");


        List<Activity> activities = new List<Activity>();

        Activity runningActivity = new Running(new DateTime(2023, 12, 05), 30, 3.0);
        Activity cyclingActivity = new Cycling(new DateTime(2023, 12, 05), 60, 6.0);
        Activity swimmingActivity = new Swimming(new DateTime(2023, 12, 55), 45, 40);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}