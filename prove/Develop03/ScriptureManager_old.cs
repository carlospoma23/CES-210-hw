using System;
using System.Collections.Generic;
using System.IO;
public class ScriptureManager
{

    private List<Scripture> _scriptures = new List<Scripture>();


    public void addScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }


    public void memorizeScripture()
    {
        // Check if there are any scriptures to memorize
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("There are no scriptures for memorization.");
            return;
        }

        // Prompt user to choose a scripture
        Console.WriteLine("Choose a scripture to memorize:");
        for (int i = 0; i < _scriptures.Count; i++)
        {
            // Display the reference correctly using GetDisplayReferenceText()
            Console.WriteLine($"{i + 1}. {_scriptures[i].getReference().GetDisplayReferenceText()}");
        }

        // Get user selection
        Console.Write("Enter the number of the scripture: ");
        int scriptureIndex;
        bool validInput = int.TryParse(Console.ReadLine(), out scriptureIndex);
        if (!validInput || scriptureIndex < 1 || scriptureIndex > _scriptures.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }
        scriptureIndex--; // Adjust for zero-based index

        // Select the scripture based on the user's choice
        Scripture selectedScripture = _scriptures[scriptureIndex];

        // Start the memorization process
        bool allWordsHidden = false;

        while (!allWordsHidden)
        {
            // Clear the console and display the scripture with the hidden words
            Console.Clear();
            selectedScripture.getDisplay();  // Display the scripture text with hidden words

            // Prompt user to hide more words or quit
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to stop.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide random words from the scripture
            selectedScripture.HideRandomWords(3); // Hides 3 words at a time
            allWordsHidden = selectedScripture.isCompletelyHidden();
        }

        // If all words are hidden, display completion message
        if (allWordsHidden)
        {
            Console.WriteLine("All words are hidden. You've completed memorizing the scripture!");
        }
    }





    // Method to display all scriptures in the manager
    // Method to display all scriptures in the manager
    public void displayAllScriptures()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures have been added yet.");
            return;
        }

        foreach (Scripture scripture in _scriptures)
        {
            // Display the reference in the correct format
            Console.WriteLine($"{scripture.getReference().GetDisplayReferenceText()}");

            // Call getDisplay() to show the scripture text (assuming it prints the text itself)
            scripture.getDisplay();  // If this method already handles printing, no need for Console.WriteLine()

            Console.WriteLine(); // Blank line for better readability
        }
    }



    // Save all scriptures to a file
    public void saveScriptures(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Scripture scripture in _scriptures)
            {
                writer.WriteLine($"{scripture.getReference()}|{string.Join(" ", scripture.getWords())}");
            }
        }
        Console.WriteLine("Scriptures saved successfully.");
    }

    // Load scriptures from a file
    public void loadScriptures(string filename)
    {
        if (File.Exists(filename))
        {
            _scriptures.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    Reference _reference = new Reference(parts[0]);
                    Scripture _scripture = new Scripture(_reference, parts[1]);
                    _scriptures.Add(_scripture);
                }
            }
            Console.WriteLine("Scriptures loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }


}

