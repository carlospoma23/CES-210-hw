public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Setting Getters and Setters for each variable
    public string getBook()
    {
        return _book;
    }

    public void setBook(string book)
    {
        _book = book;
    }

    public int getChapter()
    {
        return _chapter;
    }

    public void setChapter(int chapter)
    {
        _chapter = chapter;
    }

    public int getVerse()
    {
        return _verse;
    }

    public void setVerse(int verse)
    {
        _verse = verse;
    }

    public int getEndVerse()
    {
        return _endVerse;
    }

    public void setEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }


    // Setting Constructors

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    public Reference(string referenceText)
    {
        // Split the reference into book and chapter:verse
        string[] parts = referenceText.Split(' ');

        _book = parts[0]; // Assuming the book is the first part

        // Now handle the chapter:verse or chapter:verse-endVerse part
        string[] chapterVerseParts = parts[1].Split(':');

        _chapter = int.Parse(chapterVerseParts[0]);

        // Check if there's a range of verses
        string[] verseParts = chapterVerseParts[1].Split('-');
        _verse = int.Parse(verseParts[0]);

        if (verseParts.Length > 1) // There is an end verse
        {
            _endVerse = int.Parse(verseParts[1]);
        }
        else
        {
            _endVerse = _verse;
        }
    }

    // Setting functions 
    public string GetDisplayReferenceText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}: ";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}: ";
        }

    }

}

