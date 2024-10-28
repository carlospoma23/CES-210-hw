
public class Cycling : Activity
{
    private double _speed; // Speed in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _minutes) / 60; // compute and return distance in mills
    }

    public override double GetSpeed()
    {
        return _speed; // return speed in mph
    }

    public override double GetPace()
    {
        return 60 / _speed; // compute and return pace in min by milla
    }

}
