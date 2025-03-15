using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is a challenge I had today? And if I overcame it, how so? ",
            "What was the best part of my day?",
            "What did I accomplish today?",
            "How did I see the hand of the Lord in my life today?",
            "Who did I make smile today?",
            "What was the strongest emotion I felt today?",
            "What could I improve tomorrow that I fell short on today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetrandomPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(_prompts.Count);
        return _prompts[i];
    }
}