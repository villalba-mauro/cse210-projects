using System;

class Program
{
    static void Main(string[] args)
    {
        int user_guess = 0;
        int magic_number;

        Console.WriteLine("What is the magic number?");
        string input = Console.ReadLine();
        magic_number = int.Parse(input);

        while (user_guess != magic_number)
        {
        Console.WriteLine("Whats is your guess?");
        string guess = Console.ReadLine();
        user_guess = int.Parse(guess);

            if(user_guess == magic_number )
            {
                Console.WriteLine("You guessed it!");
            }

            else if (user_guess > magic_number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Lower");
            }
        }
        
    }
}