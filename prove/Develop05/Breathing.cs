/*public class Breathing : Activiy
{

public Breathing() : base("Breathing Activity", "This activity will help you relax by guiding your breathing.")
{
    /*_name = "Breathing activity.";
    _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    _duration = duration;
}

/*public void Run()
{

    DisplayEndingMessage();

        for (int i = 0; i < _duration / 2; i++) // Alternar respiraciones
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();*/
    

     /*   DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            for (int i = 5; i > 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write($"Breath in.. {i}");
                
            }
            Console.WriteLine("");
            Console.WriteLine("Breath out.."); //htaerBreath out..
        }*/
//}
//}



   /* DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
        Console.WriteLine("Breathe in...");
       Countdown(5);  // Pause for 5 seconds (change as needed)
        Console.WriteLine("Breathe out...");
        Countdown(5);  // Pause for 5 seconds (change as needed)
    }





    Console.WriteLine("Great job! You've completed the Breathing Activity.");
    

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);  // Wait for 1 second
        
        }
    }*/

/*----------------------------------------------------------------------------------------------------------------*/

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