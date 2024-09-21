using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string name = PromptUserName();
        double number = PromptUserNumber();
        double result = Math.Sqrt(number);

        DisplayResult(name, result);
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    static double PromptUserNumber()
    {
        Console.WriteLine("Please enter your favourite number:");
        double input = double.Parse(Console.ReadLine());
        return input;
        
    }

    static void DisplayResult(string name, double result )
    {
        Console.WriteLine($"{name}, the square of your number is {result}.");
    }
    
}