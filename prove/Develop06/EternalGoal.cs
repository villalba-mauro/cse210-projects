public class EternalGoal : Goal
{
    private int _timesAccomplished;
    public EternalGoal(string name, string description,int timesAccomplished, int points) : base (name, description, points, false)
    {
        _type = 2;
        _timesAccomplished = timesAccomplished;
    }
    public override void SetIsCompleted()
    {   
        _timesAccomplished += 1;
        _isCompleted = false;
        Console.WriteLine($"Congratulations! You earned {_points} points");

    }
    public override void DisplayGoal(int option)
    {
        if (option == 0) 
        {
            Console.WriteLine($"    {_name} ({_description}) -- Times accomplished: {_timesAccomplished}");
        }
        else 
        {
            Console.WriteLine($"{_name}");         
        }
    }
    public override string GetStringRep()
    {
        return $"{_type}|{_name}|{_description}|{_timesAccomplished}|{_points}";
    }
}

/*public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        // EternalGoal nunca se completa
    }

    public override bool IsComplete()
    {
        return false; // Siempre está en progreso
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}*/
