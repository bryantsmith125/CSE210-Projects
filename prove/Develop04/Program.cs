using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();
        int seconds;
        int menuUserinput = 0;

        List<string> menu = new List<string>
            {
                "Menu Options:",
                "1. Start breathing activity",
                "4. Quit",
                "Select a choice from the menu:  "


            };

        while (menuUserinput != 4)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

            switch (menuUserinput)
            {
                case 1:                  
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetActivityTime();
                    breathing.GetReady();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 4:
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                    break;
                default:
                    break;
            }
        }
    }
}