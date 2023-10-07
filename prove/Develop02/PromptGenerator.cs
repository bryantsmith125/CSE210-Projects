using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public static string[] _prompt =
    {
        "Who was someone new I met today?",
        "What was the highlight of my day?",
        "How did I see the hand of the Lord work in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could change one decision I made today, what would it be?",
        "What is one act of service I performed today?",
        "When did I feel the spirit the strongest today?",
        "Name three things I am grateful for.",
        "Who do I want to spend time with right now?",
        "When was the last time I told someone I loved them? Who was it?",
        "What brings me joy?",
        "Did I pray today?",
        "Share my favorite scripture passage.",
        "What was my favorite talk in conference?"

        };

    public List<string> _jPrompts = new List<string>(_prompt);


    public PromptGenerator()
    {

    }



    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_jPrompts.Count);
        string journalPrompt = _jPrompts[index];

        return journalPrompt;
    }

}