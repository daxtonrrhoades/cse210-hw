using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int numberSquared = SquareNumber(userNumber);

        DisplayResults(userName, numberSquared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;
        return numberSquared;
    }
    static void DisplayResults(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
    }
}