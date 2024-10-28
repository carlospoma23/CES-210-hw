
public class Cycling : Activity
{
    private double _speed; // Speed in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _minutes) / 60; // Calcula y devuelve la distancia en millas
    }

    public override double GetSpeed()
    {
        return _speed; // Devuelve la velocidad en mph
    }

    public override double GetPace()
    {
        return 60 / _speed; // Calcula y devuelve el ritmo en minutos por milla
    }

}
