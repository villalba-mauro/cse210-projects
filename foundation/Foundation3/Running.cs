/*class Running : Activity
{
    private double _distance;


/* Distance (km) = swimming laps * 50 / 1000
Distance (miles) = swimming laps * 50 / 1000 * 0.62
Speed (mph or kph) = (distance / minutes) * 60
Pace (min per mile or min per km)= minutes / distance
Speed = 60 / pace
Pace = 60 / speed */

/*public Running(double distance, string date, int duration) : base (duration,date)
{
    _distance = distance;
}

public override double calculateDistance()
{
    return _distance;
}

}*/

class Running : Activity
{
    private double distance; // en km

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / distance;
    }
}