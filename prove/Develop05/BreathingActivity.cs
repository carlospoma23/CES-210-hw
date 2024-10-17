using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void RunBreathing()
    {
        Console.Clear();
        DisplayStartingMessage();

        int duration = GetDuration();
        int inhaleTime = 5; // Time max breath in, I add this time by my self, because  I considered that 5 seconds is a good max breath in and out
        int exhaleTime = 5; // Time max breath out

        //adjust duration. I added this code for me, because what about if the user just want to spend 10 seconds for this activity.
        if (duration < 12)
        {
            inhaleTime = duration / 2;
            exhaleTime = duration / 2;
        }

        int cycles = duration / (inhaleTime + exhaleTime); // computing number of cicles (calculate)

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(inhaleTime); // breath in time calculated

            Console.Write("Now Breathe out... ");
            ShowCountDown(exhaleTime); //  breath out time calculated
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}