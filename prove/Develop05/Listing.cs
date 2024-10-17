public class Listing : Activiy
{
private List<string> _prompts;

private int _count;

public Listing (string name, string description, int duration):base(name, description, duration)
{
    _name = name;
    _description = description;
    _duration = duration;
}

public void Run()
{

}

public void GetRandomPrompt()
{

}

public List<string> GetListFromtUser()
{
    return _prompts;
}

}

