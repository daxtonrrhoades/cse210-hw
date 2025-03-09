using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");

        int userGrade = int.Parse(Console.ReadLine());

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You received a {letter}");

        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time!");
        }

    }
}