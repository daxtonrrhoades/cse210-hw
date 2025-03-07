using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();

        int userGradeInt = int.Parse(userGrade);

        string letter = "";

        if (userGradeInt >= 90)
        {
            letter = "A";
        }
        else if (userGradeInt >= 80)
        {
            letter = "B";
        }
        else if (userGradeInt >= 70)
        {
            letter = "C";
        }
        else if (userGradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You received a {letter}");

        if (userGradeInt >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time!");
        }

    }
}