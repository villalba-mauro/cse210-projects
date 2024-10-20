public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing items.")
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(4);  // Tiempo para pensar antes de listar

        Console.WriteLine("Start listing items:");
        List<string> userResponses = GetListFromUser();
        Console.WriteLine($"You listed {userResponses.Count} items.");

        DisplayEndingMessage();
        Console.Clear();
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        string input;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                responses.Add(input);
            }
        }

        return responses;
    }
}
