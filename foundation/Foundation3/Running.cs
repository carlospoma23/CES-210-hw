
public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance; // return distance
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60; // computer and return speed in MPH
    }

    public override double GetPace()
    {
        return _minutes / _distance; // Calcula y devuelve el ritmo en min por milla
    }

}