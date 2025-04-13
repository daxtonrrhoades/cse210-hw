using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            // write your prompts here
        };
    }

    public string GetrandomPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(_prompts.Count);
        return _prompts[i];
    }
}