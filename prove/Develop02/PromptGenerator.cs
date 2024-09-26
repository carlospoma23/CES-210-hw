public class PrompGenerator
{

    public List<string> _prompts = new List<string>();



    public void AddItem(string item)
    {
        _prompts.Add(item);
    }


    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";

        }
        var randomQuestion = new Random();
        int count = _prompts.Count();
        int indexVal = randomQuestion.Next(count);
        string prompt = _prompts[indexVal];
        return prompt;

    }





}