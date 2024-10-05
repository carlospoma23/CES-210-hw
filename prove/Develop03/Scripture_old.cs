using System;
using System.Collections.Generic;
public class Scripture
{

    private Reference _reference;
    private List<Word> _words;


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



    public void hideRandomWords(int numberToHide)
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
    public void getDisplay()
    {

        foreach (Word word in _words)
        {
            if (word.isHidden())
            {
                Console.Write("_ ");
            }
            else
            {
                Console.Write(word.GetDisplayText() + " ");
            }
        }
        Console.WriteLine();
        //Console.WriteLine(_reference.ToString());


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

    // Method to return the words as a list of strings (for saving/loading purposes)
    public List<string> getWords()
    {
        List<string> wordList = new List<string>();

        foreach (var word in _words)
        {
            wordList.Add(word.GetText());
        }

        return wordList;
    }



}



