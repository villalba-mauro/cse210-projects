public class Reflecting : Activiy
{
private List<string> _prompts;
private List<string> _questions;

public Reflecting (string name, string description, int duration):base(name, description, duration)
{
    _name = name;
    _description = description;
    _duration = duration;
}


public void Run()
{

}

public string GetRandomPrompt()
{
    return "";
}

public string GetRandomQuestion()
{
    return "";
}

public void DisplayPrompt()
{

}

public void DisplayQuestions()
{

}

}
