
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;



    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you did something really difficult",
            "Think of a time when you overcame a challenge.",
            "Reflect on a moment when you felt truly grateful.",
            "Think of an achievement you are proud of.",
            "Recall a moment when you showed kindness to someone.",
            "Think of a time you felt inspired by someone.",
            "When was the last time that you feel the Holy Ghost",
            "Think about your family and how they are proud of you"
        };

        _questions = new List<string>
        {
            "What did you learn from that experience?",
            "How did you feel in that moment?",
            "What made that experience meaningful?",
            "How can you apply what you learned to your life today?",
            "What would you do differently if faced with a similar situation?",
            "What do your parents, your wife or your children think about it? "
        };
    }



    public void RunReflecting()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();  // what for user to hit enter.

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);  // countdown

        // Obtener duración total
        int duration = GetDuration();
        int maxTimePerQuestion = 5; // max time per question.

        // compute number of question. 
        int numberOfQuestions = Math.Min(duration / maxTimePerQuestion, _questions.Count);

        DisplayQuestions(numberOfQuestions, maxTimePerQuestion);  // show random question.
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayQuestions(int numberOfQuestions, int timePerQuestion)
    {
        List<string> shuffledQuestions = new List<string>(_questions);  // copy questions.
        ShuffleList(shuffledQuestions);  // Mix up questions to avoid duplicates.

        // Display only the number of questions that can be displayed in the available time
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine($"\n> {shuffledQuestions[i]}"); // show question
            Thread.Sleep(timePerQuestion * 1000);  // wait time to show next question.
        }
    }

    //Method that help me avoid duplicates.
    private void ShuffleList(List<string> list)
    {
        Random random = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }




}









