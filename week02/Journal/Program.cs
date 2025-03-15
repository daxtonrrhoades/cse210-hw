using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please choose an option. Enter your option's number(1-5)");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Quit program");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetrandomPrompt();
                Console.WriteLine($"Here is your prompt: {prompt}");

                Console.WriteLine("Write your entry: ");
                string _entryText = Console.ReadLine();

                Entry newEntry = new Entry(prompt, _entryText);
                theJournal.AddEntry(newEntry);

                Console.WriteLine("Your entry has successfully been recorded.");
            }

            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the name of the file you would like to save this to? ");
                string fileName = Console.ReadLine();

                theJournal.SaveToFile(fileName);

                Console.WriteLine($"Save to {fileName} was successful");
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the name of the file you would like to load from? ");
                string fileName = Console.ReadLine();

                theJournal.LoadFromFile(fileName);
                Console.WriteLine($"Successfully loaded all journal entries from {fileName}");
            }

            else if (choice == "5")
            {
                Console.WriteLine("The program has successfully quit");
                break;
            }

            else
            {
                Console.WriteLine("That was an invalid input. Try again");
            }
        }
    }
}