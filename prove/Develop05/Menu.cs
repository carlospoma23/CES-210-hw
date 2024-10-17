using System;

public class Menu
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string _choice = Console.ReadLine();
            if (SelectItemMenu(_choice))
            {
                break; // end to the cicle, option 4
            }
        }
    }

    private bool SelectItemMenu(string choice)
    {
        switch (choice)
        {
            case "1":
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.RunBreathing();
                return false; // return menu

            case "2":
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting.RunReflecting();
                return false; // return menu

            case "3":
                ListingActivity listing = new ListingActivity("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.RunListing();
                return false; // return menu

            case "4":
                Console.WriteLine("Goodbye!");
                return true; // end menu

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return false; // return menu.
        }
    }
}
