using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{


    private int _count;
    private List<String> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
        _count = 0;
        _prompts = new List<string>

        {
            "What are you grateful for today?",
            "What is your favorite memory from the past year?",
            "Who has had the most positive impact on your life?",
            "What are ten things you love about yourself?",
            "What is one thing you would like to achieve this year?",
            "What is your happiest childhood memory?",
            "What is something that always makes you smile?",
            "What are the qualities you value most in friends?",
            "What is a lesson you've learned in the past year?",
            "What is a skill you would like to learn and why?"
        };


    }

    public void RunListing()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Take a moment to reflect on the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou may begin in:");

        List<string> responses = GetListFromUser(GetDuration());

        Console.WriteLine($"\nYou listed {responses.Count} items.");


        DisplayEndingMessage();
    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }


    public List<string> GetListFromUser(int durationInSeconds)
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        //Console.WriteLine($"You have {durationInSeconds} seconds to list your responses:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);  // Agrega la respuesta si no está vacía
            }
        }

        //Console.WriteLine("\nTime's up! No more entries allowed.");
        return responses;
    }

}

