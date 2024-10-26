using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? : ");
        string name = Console.ReadLine();

        Console.Write("What is the short description of it? : ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associeted with this goal? : ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null; // Variable to hold the created goal

        // Create the correct type of goal based on user's choice
        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? : ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("what is the bonus for accomplishing it that many times? : ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice, goal not created.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }
    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet.");
        }
        else
        {
            Console.WriteLine("Your goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                // call  GetDetailsString()
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(); // I will delete
    }

    public void SaveGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to save.");
            return;
        }

        Console.Write("what is the filename for the goal file? : ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score); //saving point on the first lane.
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(); // I will delete
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file?: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. Please try again.");
            //Console.WriteLine("Press any key to return to the menu...");
            // Console.ReadKey(); // For testing, can be removed
            return;
        }

        _goals.Clear(); // Clear the list

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine()); // Read the score on the first line
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal goal = null;

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]); // Read completion status
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                            simpleGoal.SetComplete(isComplete); // Set completion status
                            goal = simpleGoal;
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal(name, description, points);
                            break;
                        case "ChecklistGoal":
                            int bonus = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int amountCompleted = int.Parse(parts[6]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                            checklistGoal.SetAmountCompleted(amountCompleted);
                            goal = checklistGoal;
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type: {goalType}. Skipping this line.");
                            continue;
                    }

                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
        }

        //Console.WriteLine("Press any key to return to the menu...");
        //Console.ReadKey(); // Pause, can be removed
    }


    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record an event for.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");

            // Validar si todos los SimpleGoals y ChecklistGoals están completos
            bool allGoalsComplete = true;
            for (int i = 0; i < _goals.Count; i++)
            {
                // Verifica solo las metas de tipo SimpleGoal y ChecklistGoal
                if ((_goals[i] is SimpleGoal || _goals[i] is ChecklistGoal) && !_goals[i].IsComplete())
                {
                    allGoalsComplete = false;
                    break;
                }
            }

            if (allGoalsComplete)
            {
                Console.WriteLine("Fantastic! You've accomplished all your SIMPLE and CHECKIST GOALS goals! Keep up the amazing work!");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine(); // wait for enter
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }




    public int GetTotalScore()
    {
        return _score;

    }
}
