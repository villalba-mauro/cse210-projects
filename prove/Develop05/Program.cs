using System;

class Program
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


    


}