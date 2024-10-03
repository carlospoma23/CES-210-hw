public class Scripture
{

    Reference _reference;
    List<Word> _words;


    public Reference getReference()
    {
        return _reference;
    }

    public void setReference(Reference reference)
    {
        _reference = reference;
    }

    //Setting Constructors
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();
        //spliting the scripture

        string[] wordArray = scriptureText.Split(' ');

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }

    }

    //Method hide randomly words
    public void HideRandomWords(int numberToHide)
    {
        Random _random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int randomIndex = _random.Next(_words.Count);

            if (!_words[randomIndex].isHidden())
            {
                _words[randomIndex].Hide();
                wordsHidden++;
            }

            if (isCompletelyHidden())
            {
                break;
            }
        }
    }

    //Method allows to display scripture text and its reference.
    public void GetDisplay()
    {
        Console.Clear();
        Console.Write(_reference.GetDisplayReferenceText());
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();


    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {

            if (!word.isHidden())
            {
                return false;
            }

        }
        return true;
    }

}



