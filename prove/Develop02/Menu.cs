using System.Security.Cryptography;
using Microsoft.VisualBasic;

public class Menu()
{

    public List<string> _menuL = new List<string>();


    public void AddItem(string item)
    {
        _menuL.Add(item);
    }

    public void DisplayMenu()
    {
        for (int i = 0; i < _menuL.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_menuL[i]}");
        }
    }

    public int SelectItemMenu()
    {
        Console.Write("What do you like to do: ");
        int index;
        string input = Console.ReadLine();
        //index = Convert.ToInt32(input); // convert string to integer.

        if (int.TryParse(input, out index) && index > 0 && index <= _menuL.Count)
        {
            return index;
        }
        else
        {
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            return SelectItemMenu(); // loop call.
        }

    }







}