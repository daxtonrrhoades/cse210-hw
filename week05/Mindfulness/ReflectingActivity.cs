using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting activity", "This activity will give you a random prompt and question to reflect on.", 0)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine("Ponder the following prompt: ");
        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("Now ponder the following questions: ");
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < GetDuration())
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"{question}");
            ShowSpinner(7);
            elapsed += 7;
        }

        DisplayEndingMessage();
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }
}