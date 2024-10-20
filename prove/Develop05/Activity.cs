public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine();
        Console.Write("How long,in seconds, would you like for your session?:");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        Thread.Sleep(2000);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b/");
            Thread.Sleep(250);
            Console.Write("\b \b-");
            Thread.Sleep(250);
            Console.Write("\b \b\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        } 
/*         List<string> stringAnimation = new List<string>();

            stringAnimation.Add("|");
            stringAnimation.Add("/");
            stringAnimation.Add("-"); 
            stringAnimation.Add("\\");
            stringAnimation.Add("|");
            stringAnimation.Add("/");
            stringAnimation.Add("-");
            stringAnimation.Add("\\");
        int mseconds = seconds * 70;
        foreach(string s in stringAnimation) */
/*         {
            Console.Write(s);
            Thread.Sleep(mseconds);
            Console.Write("\b \b");
        } */
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public abstract void Run();  // Método abstracto a implementar en las subclases
}
