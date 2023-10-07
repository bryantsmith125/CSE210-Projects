using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    private string _fileName;



    public Journal()
    {

    }

    public void DisplayJournalEntries()
    {
        Console.WriteLine("\nJournal Entries     ");
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.DisplayEntry();
        }
    }


    public void SaveToCSV()
    {
        Console.Write("What is the file name? ");
        string userInput = Console.ReadLine();
        _fileName = userInput;

        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry journalEntry in _journal)
                outputFile.WriteLine($"{journalEntry._date}|{journalEntry._prompt}|{journalEntry._response}");
        }


    }

    public void LoadFromCSV()
    {
        Console.Write("What the journal file name? ");
        string userInput = Console.ReadLine();
        _fileName = userInput;

        List<string> readFile = File.ReadAllLines(_fileName).ToList();
        foreach (string line in readFile)
        {
            string[] entry = line.Split("|");

            string _date = entry[0];
            string _prompt = entry[1];
            string _response = entry[2];
        }

    }

}