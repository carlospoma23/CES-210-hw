public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()

    {

        Console.WriteLine($"\n Welcome to the {_name}");
        Console.WriteLine($"\n This activity will help you {_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? : ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.Clear();

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner();

    }
    public void ShowSpinner()
    {

        List<string> animationsStrings = new List<string>();
        animationsStrings.Add("|");
        animationsStrings.Add("/");
        animationsStrings.Add("-");
        animationsStrings.Add("\\");
        animationsStrings.Add("|");
        animationsStrings.Add("/");
        animationsStrings.Add("-");
        animationsStrings.Add("\\");

        foreach (string s in animationsStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        /*
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
*/
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }





}