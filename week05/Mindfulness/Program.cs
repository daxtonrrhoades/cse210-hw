using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit program");
            Console.Write("Select a choice(1-4) from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                // This is the breathing activity
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
            }

            else if (choice == "2")
            {
                // this is the reflecting activity
                List<string> prompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };

                List<string> questions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };

                ReflectingActivity reflect = new ReflectingActivity(prompts, questions);
                reflect.Run();
            }

            else if (choice == "3")
            {
                // this is the listing activity
                List<string> prompts = new List<string>
                {
                    "When have you felt the Holy Ghost this month?",
                    "Who do you look up to a lot?",
                    "What are your greatest weaknesses?",
                    "What are your greatest strengths?",
                    "who are some of your personal heroes?"
                };

                ListingActivity list = new ListingActivity(0, prompts);
                list.Run();
            }

            else if (choice == "4")
            {
                // this allows the user to quit the program
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