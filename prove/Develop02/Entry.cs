public class Entry
{

    public string _date;
    public string _promptText;

    public string _entryText;


    public Entry(string promptText, string entryText)
    {

        _date = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }



    public void Display()
    {

        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Answer: {_entryText}");
        Console.WriteLine("------------------------------------------------------------------");


    }

}