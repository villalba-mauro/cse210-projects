using System;

/*class Program
{
    static void Main(string[] args)
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

    DateTime starTime = DateTime.Now;
    DateTime endTime = starTime.AddSeconds(10);

    int i = 0;

    while(DateTime.Now < endTime)
    {
        string s = stringAnimation[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i++;

        if (i >= stringAnimation.Count)
        {
            i = 0;
        }

    }

    
    
    bool running = true;
    while (running)
    {
        Console.WriteLine("1. Start Breathing activity");
        Console.WriteLine("2. Start Reflecting activity");
        Console.WriteLine("3. Start Listing activity");
        Console.WriteLine("4. Quit");

        Console.Write("Choice one activity: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
                
            case "1":
            {
            Breathing activity1 = new Breathing("","",5);
            activity1.Run();
            Console.WriteLine("has elegido la opcion 1");
            break;
            }
           
            case "2":
            {
            Console.WriteLine("has elegido la opcion 2");
            break;
            }

            case "3":
            {
             Console.WriteLine("has elegido la opcion 3");
            break;
            }
            case "4":
            {
            running = false;
            break;
            }

            default:
            {
            Console.WriteLine("Invalid option, please try again.");
            break;  
            }        
        } 
    }

    }
}*/
/*----------------------------------------------------------------------------------------------------------------*/
using System;
using System.Security.Claims;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    RunBreathingActivity();
                    break;
                case "2":
                    Console.Clear();
                    RunListingActivity();
                    break;
                case "3":
                    Console.Clear();
                    RunReflectingActivity();
                    break;
                case "4":
                    
                    Console.WriteLine("Exiting program. Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Thread.Sleep(2000); // Pausa para que el usuario vea el mensaje
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Run();
    }

    static void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run();
    }

    static void RunReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run();
    }
}
