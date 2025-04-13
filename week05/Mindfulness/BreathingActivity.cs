using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing activity", "This activity will walk you along some breathing exercises to help you relax", 0)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;

        while (elapsed < GetDuration())
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            elapsed += 5;

            Console.WriteLine();

            if (elapsed >= GetDuration())
            {
                break;
            }

            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            elapsed += 5;

            Console.WriteLine();
        }

        DisplayEndingMessage();
        Console.Clear();
    }
}