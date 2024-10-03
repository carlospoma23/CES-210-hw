public class Menu
{
    private ScriptureManager _scriptureManager;

    public Menu(ScriptureManager manager)
    {
        _scriptureManager = manager;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("1. Enter (New Scripture)");
        Console.WriteLine("2. Display Scriptures");
        Console.WriteLine("3. Load Scriptures");
        Console.WriteLine("4. Save Scriptures");
        Console.WriteLine("5. Memorization of Scripture");
        Console.WriteLine("6. Quit");
    }

    public void ProcessSelection()
    {
        int _choice = int.Parse(Console.ReadLine());

        switch (_choice)
        {
            case 1:
                scriptureManager.EnterNewScripture();
                break;
            case 2:
                scriptureManager.DisplayScriptures();
                break;
            case 3:
                scriptureManager.LoadScriptures();
                break;
            case 4:
                scriptureManager.SaveScriptures();
                break;
            case 5:
                scriptureManager.MemorizeScripture();
                break;
            case 6:
                Console.WriteLine("Thank you for your time Good Bye!");
                break;
        }
    }
}