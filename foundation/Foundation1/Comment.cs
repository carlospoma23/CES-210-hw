using System;
using System.Collections.Generic;
public class Comment
{

    public string _commenterName;
    public string _commenterText;


    public Comment(string name, string comment)
    {
        _commenterName = name;
        _commenterText = comment;


    }

    public void ShowComment()
    {

        Console.WriteLine($"{_commenterName} : {_commenterText}");

    }

}