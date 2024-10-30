/*class Cycling : Activity
{
private double _speed;

public Cycling (double speed, string date, int duration) : base (duration,date)
{
    _speed = speed;
}


public override double calculateSpeed()
{
    return _speed;
}

public override double calculatePace()
{
    return 60 / _speed;
}

public override double calculateDistance()
{
    return GetMinutes() * _speed /calculateDistance();
}
}*/

class Cycling : Activity
{
    private double speed; // en kph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * duration) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}