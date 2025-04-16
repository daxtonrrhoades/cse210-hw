using System;

class Program
{
    static void Main(string[] args)
    {
        Running exercise1 = new Running("25 May, 2005", 45, 4.5);
        StationaryBike exercise2 = new StationaryBike("04 May, 2025", 40, 20.5);
        Swimming exercise3 = new Swimming("04 July, 2025", 25, 40);

        Console.WriteLine(exercise1.GetSummary());
        Console.WriteLine();
        Console.WriteLine(exercise2.GetSummary());
        Console.WriteLine();
        Console.WriteLine(exercise3.GetSummary());
    }
}