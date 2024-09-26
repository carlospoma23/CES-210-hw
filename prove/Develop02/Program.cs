using System;
using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        //Adding Items to the Menu
        Menu myMenu = new Menu();
        Console.WriteLine("Please select one of the following Choices: ");
        myMenu.AddItem("Write");
        myMenu.AddItem("Display");
        myMenu.AddItem("Load");
        myMenu.AddItem("Save");
        myMenu.AddItem("Quit");


        PrompGenerator myPrompts = new PrompGenerator();

        myPrompts.AddItem("Was the most interesting person I interacted with today?");
        myPrompts.AddItem("What was the best part of my day?");
        myPrompts.AddItem("How did I see the hand of the Lord in my life today?");
        myPrompts.AddItem("What was the strongest emotion I felt today?");
        myPrompts.AddItem("How do you feel today");
        myPrompts.AddItem("If I had one thing I could do over today, what would it be?");
        myPrompts.AddItem("Did you improve your skills today, how?");


        Journal myJournal = new Journal();

        bool _exit = false;
        while (!_exit)
        {
            myMenu.DisplayMenu();
            int _userChoice = myMenu.SelectItemMenu();
            switch (_userChoice)

            {
                case 1: //write
                    string _randomPront = myPrompts.GetRandomPrompt();
                    Console.WriteLine(_randomPront);
                    Console.Write("> ");
                    string _userResponse = Console.ReadLine();
                    Entry newEntry = new Entry(_randomPront, _userResponse);
                    myJournal.AddEntry(newEntry);

                    break;
                case 2: //display
                    myJournal.DisplayAll();
                    break;

                case 3: //load
                    Console.WriteLine("What is the filename? ");
                    string _loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(_loadFile);
                    //Console.WriteLine($"Entradas cargadas: {myJournal._entries.Count}");
                    break;

                case 4: //Save
                    Console.WriteLine("What is the filename? ");
                    string _fileSave = Console.ReadLine();
                    myJournal.SaveToFile(_fileSave);

                    break;
                case 5://Quit

                    Console.WriteLine("Thank you, have a wonderful day!");
                    _exit = true;
                    break;

            }






        }
        //testing the correct index
        //Console.WriteLine($"you are selected the option nro : {_userChoice}");










    }
}