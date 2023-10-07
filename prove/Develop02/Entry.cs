using System;

public class Entry
{
    public string _journalEntry = "";
    public string _date = "";
    public string _prompt = "";
    public string _response = "";


    public Entry()
    {

    }



    public void DisplayEntry()
    {
        {
            Console.WriteLine($"Date: {_date} ~ Prompt: {_prompt}");
            Console.WriteLine($"{_response}\n");
        }
    }


}