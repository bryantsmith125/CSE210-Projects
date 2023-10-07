using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();

        Journal journal = new Journal();
        int menuUserinput = 0;
        PromptGenerator rJournalPrompt = new PromptGenerator();

        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do?"
            };

        while (menuUserinput != 5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

            switch (menuUserinput)
            {
                case 1:
                    string _date = GetDate();
                    string _prompt = rJournalPrompt.GetRandomPrompt();

                    Entry entry = new Entry();
                    entry._date = _date;
                    entry._prompt = _prompt;

                    Console.Write($"{_prompt}\n");
                    Console.Write("> ");
                    string userJournalEntry = Console.ReadLine();
                    entry._response = userJournalEntry;

                    journal._journal.Add(entry);
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    journal.LoadFromCSV();
                    break;
                case 4:
                    journal.SaveToCSV();
                    break;
                default:
                    break;
            }
        }

    }
    static string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}