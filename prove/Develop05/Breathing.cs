public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 2; i++) // Alternar respiraciones
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("");
            Console.Write($"Breathe out...");
            ShowCountDown(3);
            Console.WriteLine("");
            Console.WriteLine("");

            
            

        }


        DisplayEndingMessage();
    }

}