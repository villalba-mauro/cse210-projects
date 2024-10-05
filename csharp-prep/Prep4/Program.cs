using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Verificar si la lista tiene al menos un número
        if (numbers.Count > 0)
        {
            // Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Compute the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the max
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            // Find the smallest positive number
            int smallestPositive = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
            // Comprobar si se encontró un número positivo
            if (smallestPositive == int.MaxValue)
            {
                Console.WriteLine("There are no positive numbers.");
            }
            else
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Sort the list
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
