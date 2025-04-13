using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit Program");
            Console.Write("Select a choice(1-6) from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                // here you can create a new goal
                CreateGoal();
            }

            else if (choice == "2")
            {
                // here you can list your goals
                ListGoalDetails();
            }

            else if (choice == "3")
            {
                // here you can save your goals
                SaveGoals();
            }

            else if (choice == "4")
            {
                // here you can load your goals
                LoadGoals();
            }

            else if (choice == "5")
            {
                // here you can record an event
                RecordEvent();
            }

            else if (choice == "6")
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

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName}");
            index++;
        }
    }

    public void ListGoalDetails()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailedString()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?(1-3) ");

        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter goal points: ");
        string points = Console.ReadLine();

        if (choice == "1")
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (choice == "2")
            _goals.Add(new EternalGoal(name, desc, points));
        else if (choice == "3")
        {
            Console.Write("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");

        int index = int.Parse(Console.ReadLine()) - 1;
        Goal selectedGoal = _goals[index];
        selectedGoal.RecordEvent();

        int points = selectedGoal.GetPoints();
        _score += points;

        if (selectedGoal is ChecklistGoal checklist && checklist.isComplete())
        {
            _score += checklist.GetBonus();
        }

        Console.WriteLine($"You earned {points} points!");
    }

    public void SaveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        _goals.Clear();

        foreach (string line in lines)
        {

            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            else
            {
                string[] parts = line.Split(",");

                string goalType = parts[0];

                if (goalType == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        goal.RecordEvent();
                    }

                    _goals.Add(goal);
                }

                else if (goalType == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }

                else if (goalType == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    goal.LoadAmountCompleted(amountCompleted);
                    _goals.Add(goal);
                }
            }
        }
    }
}