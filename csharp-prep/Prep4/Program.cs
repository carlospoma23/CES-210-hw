using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep4 !");

        List<int> listNumbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                listNumbers.Add(userNumber);
            }
        }
        //sum
        int sum = 0;
        foreach (int number in listNumbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //average
        float average = ((float)sum) / listNumbers.Count;
        Console.WriteLine($"The average is: {average}");

        //largest
        int max = listNumbers[0];
        foreach (int number in listNumbers)
        {
            if (number > max)
            {
                max = number;
            }

        }
        Console.WriteLine($"The largest number is: {max}");

        //smallest positive

        int min = int.MaxValue;

        foreach (int number in listNumbers)
        {

            if (number > 0 && number < min)
            {
                min = number;

            }
        }
        if (min != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {min}");

        }

        //sort

        listNumbers.Sort();

        Console.WriteLine("The Sorted list: " + string.Join(", ", listNumbers));



    }
}