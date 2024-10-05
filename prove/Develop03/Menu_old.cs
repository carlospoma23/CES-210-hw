public class Menu
{
    private ScriptureManager _scriptureManager;

    public Menu(ScriptureManager manager)
    {
        _scriptureManager = manager;
    }

    // Method to display the menu
    public void displayMenu()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Enter (New Scripture)");
        Console.WriteLine("2. Display Scriptures");
        Console.WriteLine("3. Load Scriptures");
        Console.WriteLine("4. Save Scriptures");
        Console.WriteLine("5. Memorization of Scripture");
        Console.WriteLine("6. Quit");
    }

    // Method to select and handle menu options
    public void selectMenuItem()
    {
        bool _keepMenu = true;

        while (_keepMenu)
        {
            displayMenu();  
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            int choice;

            bool isValidChoice = int.TryParse(input, out choice);

            if (!isValidChoice)
            {
                Console.WriteLine("Invalid choice. Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    // Option to add 
                    AddNewScripture();
                    break;
                case 2:
                    // Option to display all 
                    _scriptureManager.displayAllScriptures();
                    break;
                case 3:
                    // Option to load scriptures from a file
                    Console.Write("Enter the filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    _scriptureManager.loadScriptures(loadFilename);
                    break;
                case 4:
                    // Option to save scriptures to a file
                    Console.Write("Enter the filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    _scriptureManager.saveScriptures(saveFilename);
                    break;
                case 5:
                    // Option for scripture memorization
                    _scriptureManager.memorizeScripture();
                    break;
                case 6:
                    // Option to quit the program
                    Console.WriteLine("Thank you for your time. Goodbye!");
                    _keepMenu = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine(); // To give some space before showing the menu again
        }
    }

    // Helper method to add a new scripture
    private void AddNewScripture()
    {
        // Prompt for scripture reference input
        Console.Write("Enter the book name: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter number: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the verse number: ");
        int verse = int.Parse(Console.ReadLine());

        Console.Write("Enter the end verse number (if applicable, or press enter to skip): ");
        string endVerseInput = Console.ReadLine();
        int endVerse = verse;

        if (!string.IsNullOrEmpty(endVerseInput))
        {
            endVerse = int.Parse(endVerseInput);
        }

        // Prompt for the scripture text input
        Console.Write("Enter the scripture text: ");
        string scriptureText = Console.ReadLine();

        // Create Reference and Scripture objects
        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, scriptureText);

        // Add the new scripture to the manager
        _scriptureManager.addScripture(scripture);
        Console.WriteLine("Scripture added successfully!");
    }
}
