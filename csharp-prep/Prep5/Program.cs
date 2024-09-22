using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Prep5 ");

        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sNumber = SquareNumber(userNumber);
        DisplayResult(userName, sNumber);





        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name :");
            string name = Console.ReadLine();

            return name;

        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;

        }


        static int SquareNumber(int n)
        {
            int squareN = n * n;

            return squareN;
        }

        static void DisplayResult(string n, int s)
        {
            Console.WriteLine($"{n}, the square of your number is {s}");
        }


    }
}