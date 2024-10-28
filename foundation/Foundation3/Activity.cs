using System;
using System.Collections.Generic;

// Clase base
public class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }


    // I will use F1 because it tell me the format of the number: F format, 1 one decimal number after point.
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F1}";
    }
}


