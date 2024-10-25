public abstract class Goal
{
    protected bool _isCompleted;
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _type;

    public Goal (string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    public abstract void SetIsCompleted();
    public abstract void DisplayGoal(int option); //user.RecordEvent will use the option to show a list of the goals without the checkbox and description
    public abstract string GetStringRep();


    //GETTERS
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public int GetPoints()
    {
        return _points;
    }

}

/*public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
*/