using System;

public class Menu
{
    private GoalManager _goalManager; // Reference to the GoalManager

    public Menu(GoalManager goalManager)
    {
        _goalManager = goalManager; // Pass the GoalManager instance to the menu
    }



    public void DisplayMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You have {_goalManager.GetTotalScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string _choice = Console.ReadLine();
            if (SelectItemMenu(_choice))
            {
                break; // Salir del ciclo, opción 6
            }
        }
    }

    private bool SelectItemMenu(string choice)
    {
        switch (choice)
        {
            case "1":
                Console.Clear();
                _goalManager.CreateGoal();
                return false; // return menu

            case "2":
                _goalManager.ListGoals();
                return false; // return menu

            case "3":
                _goalManager.SaveGoals();
                return false; // return menu

            case "4":
                _goalManager.LoadGoals();
                return false; // return menu

            case "5":
                _goalManager.RecordEvent();
                return false; // return menu

            case "6":
                Console.WriteLine("Goodbye!");
                return true; // end menu

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return false; // Vreturn menu, invalid option.
        }
    }
}
