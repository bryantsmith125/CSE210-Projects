using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(reference, "Trust in the lord with all thine heart and lean not unto thine own " + 
            "understanding; In all thy ways acknowledge him, and he shall direct thy paths.");
        string userInput = "";

        while (userInput != "quit"  && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
            
        }

        Console.WriteLine("I hope tha you were able to memorize the scripture!");

    }
}