/*public class Reflecting : Activiy
{
private List<string> _prompts;
private List<string> _questions;

public Reflecting (int duration, string description, string name) : base (name, description,duration)
{
    _name = name;
    _description = description;
    _duration = duration;
    _prompts = new List<string>();
    _questions = new List<string>();
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

}*/

/*----------------------------------------------------------------------------------------------------------------*/

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",


    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on past experiences.")
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(GetRandomQuestion());
            Console.Write(" " );
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
