using System.Net.Http.Headers;

/*class Activity
{
    private int _duration;
    private string _date;


public Activity (int duration, string date)
{
    _duration = duration;
    _date = date;
}

public double GetMinutes()
{
    return _duration;
}

public string GetDate()
{
    return _date;
}
public virtual double calculateDistance()
{
    return 0.0;
}

public virtual double calculateSpeed()
{
    return calculateDistance() / _duration * 60;
}
public virtual double calculatePace()
{
    return _duration / calculateDistance();
}


public string GetSummary() 
{
  return $"{_date}: {GetType().Name} ({_duration} min.) : Distance {calculateDistance()} km, Speed: {calculateSpeed()} kph, Pace: {calculatePace()} min. per km";
}

}*/

class Activity
{
    protected DateTime date;
    protected int duration; // en minutos

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    // Métodos virtuales para distancia, velocidad y ritmo
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / duration) * 60;
    }

    public virtual double GetPace()
    {
        return duration / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {this.GetType().Name} ({duration} min): " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.0} min per km";
    }
}

