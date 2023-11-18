using System;

public class MainMenu
{
    public int UserChoice()
    {
        Console.WriteLine("\nMain Menu:");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");

        int choice;
        while (true)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= 1 && choice <= 6)
                    return choice;
            }
            Console.WriteLine("Please try again.");
        }
    }
}