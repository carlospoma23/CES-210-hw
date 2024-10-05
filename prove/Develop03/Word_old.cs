public class Word
{
    private string _text;
    private bool _isHidden;

    //constructors

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Setting getters and Setters for each variable
    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }



    /*
        public bool GetIsHidden()
        {
            return _isHidden;
        }
    */
    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    //creating Functions or methods.

    //Method that Hide the word
    public void Hide()
    {
        _isHidden = true;

    }
    //method show the word
    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }
    //method allow to show the word (hidden or visible)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }

    }

}
