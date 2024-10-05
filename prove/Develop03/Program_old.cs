class Program
{
    static void Main(string[] args)
    {
        // Initialize the ScriptureManager without parameters
        ScriptureManager _scriptureManager = new ScriptureManager();

        // Initialize the Menu with the scripture manager
        Menu _menu = new Menu(_scriptureManager);



        //call function to show Menu.
        _menu.selectMenuItem();


    }

}


