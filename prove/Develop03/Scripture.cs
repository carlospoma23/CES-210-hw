using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference _scriptureReference = new Reference("Proverbs", 3, 5, 6);

        //Scripture text;
        string _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture _scripture = new Scripture(_scriptureReference, _scriptureText);

        while (true)
        {
            _scripture.GetDisplay();

            if (_scripture.isCompletelyHidden())
            {
                Console.WriteLine("all words have been hidden");
                break;

            }

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Thank you, You did a great job.");
                break;
            }

            _scripture.HideRandomWords(3);


        }

    }
}