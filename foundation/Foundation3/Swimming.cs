// Clase derivada para Swimming
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50.0) / 1000.0 * 0.62; // Distance in miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60; // mph
    }

    public override double GetPace()
    {
        return _minutes / GetDistance(); // min per mile
    }

}