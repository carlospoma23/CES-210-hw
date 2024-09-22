using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep2");
        Console.Write("Welcome to Program that determines the letter grade for a course");
        Console.WriteLine();
        Console.Write("What is your grade percentage in this course: ");
        double grade = double.Parse(Console.ReadLine());
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");


        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine($"I am so sorry! You didn't passe the course! Please come back you can do it!");
        }



    }
}