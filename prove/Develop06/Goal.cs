public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }




    public string GetShortName()
    {
        return _shortName;
    }


    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }


    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent(); // Each derived class will implement how points are gained
    public abstract bool IsComplete(); // Each derived class will determine if it's complete

    public virtual string GetDetailsString()
    {
        string status;
        if (IsComplete())
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $" {status} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
