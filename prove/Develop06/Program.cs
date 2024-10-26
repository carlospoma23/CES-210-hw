using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(); // Create the GoalManager instance
        Menu menu = new Menu(goalManager); // Create the Menu instance
        menu.DisplayMenu(); // Show the menu
    }
}