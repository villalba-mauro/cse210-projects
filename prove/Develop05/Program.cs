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
        Console.Clear();
        //WaitBeforeMenu();
    }

    static void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run();
       Console.Clear();
       //WaitBeforeMenu();
        
    }

    static void RunReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run();
        Console.Clear();
       //WaitBeforeMenu();
    }

        // Método para pausar y luego limpiar la consola antes de volver al menú
    static void WaitBeforeMenu()
    {
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();  // Espera a que el usuario presione una tecla
        Console.Clear();  // Limpia la consola antes de volver al menú
    }
}

