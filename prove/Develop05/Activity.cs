public class Activiy
{
protected string _name;
protected string _description;
protected int _duration;

public Activiy(string name, string description, int duration)
{
    _name = name;
    _description = description;
    _duration = duration;
}

public string DisplayStartingMessage()
{
    
    return $"Welcome to the {_name} Activity";
}

public string DisplayEndingMessage()
{
 return "";
}

public void ShowSpinner(int seconds)
{
 List<string> stringAnimation = new List<string>();

    stringAnimation.Add("|");
    stringAnimation.Add("/");
    stringAnimation.Add("-"); 
    stringAnimation.Add("\\");
    stringAnimation.Add("|");
    stringAnimation.Add("/");
    stringAnimation.Add("-");
    stringAnimation.Add("\\");
    int mseconds = seconds * 1000;
    foreach(string s in stringAnimation)
    {
        Console.Write(s);
        Thread.Sleep(mseconds);
        Console.Write("\b \b");
    }
}

public void ShowCountDown(int seconds)
{
    
}

}

