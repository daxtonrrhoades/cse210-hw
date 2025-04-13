using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int count, List<string> prompts) : base("Listing activity", "This activity will have you list as many items as you can given a single prompt.", 0)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"List as many items as you can to the following prompt:\n {prompt}");
        Console.Write("Get ready to start in:");
        ShowCountDown(3);
        Console.WriteLine();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        List<string> responses = new List<string>();

        while (DateTime.Now < end)
        {
            Console.Write("- ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
        Console.Clear();
    }
}