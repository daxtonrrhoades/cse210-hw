using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to start...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of ther {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}