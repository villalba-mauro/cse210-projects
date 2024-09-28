using System;

class Program
{
    static void Main(string[] args)
    {
       
        List<int> numbers = new List<int>();
        int input =-1;

        while (input != 0)
        {
            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        
            int sum = 0;
            int largest = numbers[0];

            foreach(int number in numbers)
            {
                sum += number;

                if (number > largest)
                {
                    largest = number;
                }
            }

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}