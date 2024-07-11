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

    // Display the player's score before showing the menu
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            DisplayMenu();
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            // Wait for user input before clearing the screen
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select an option: ");
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        int type;
        if (!int.TryParse(Console.ReadLine(), out type))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points;
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        Goal goal = null;

        switch (type)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target: ");
                int target;
                if (!int.TryParse(Console.ReadLine(), out target))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    return;
                }
                Console.Write("Enter bonus points: ");
                int bonus;
                if (!int.TryParse(Console.ReadLine(), out bonus))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    return;
                }
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Enter the goal number you accomplished: ");
        int goalNumber;
        if (!int.TryParse(Console.ReadLine(), out goalNumber) || goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[goalNumber - 1];
        int pointsEarned = goal.RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = null;

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    goal = new SimpleGoal(name, description, points, isComplete);
                }
                else if (type == "EternalGoal")
                {
                    goal = new EternalGoal(name, description, points);
                }
                else if (type == "ChecklistGoal")
                {
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                }

                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}
