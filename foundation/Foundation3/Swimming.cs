/*class Swimming : Activity
{
    private double _laps;   

public Swimming(double laps,string date, int duration) : base (duration, date)
{
    _laps = laps;
    
}

public override double calculateDistance()
{
    return  _laps * 50 / 1000;
}

}*/

class Swimming : Activity
{
    private int laps;
    private const double lapDistance = 0.05; // cada vuelta es de 50 metros o 0.05 km

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * lapDistance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / GetDistance();
    }
}
