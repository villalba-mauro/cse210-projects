using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string input = Console.ReadLine();

        int percentage = int.Parse(input);

        string grade;

        if (percentage >=90)
        {
            grade = "A";
            Console.WriteLine("Congratulations on your hard work and effort, you have passed the course.");
        }

        else if (percentage >=80)
        {
            grade = "B";
            Console.WriteLine("Congratulations, you have passed the course.");
        }

         else if (percentage >= 70)
        {
            grade = "C";
            Console.WriteLine("well done you have passed the course, keep up the good work.");
        }

        else if (percentage >= 60)
        {
            grade = "D";
            Console.WriteLine("You have not passed the course, keep trying hard for the next one.");
        }

        else
        {
            grade = "F";
            Console.WriteLine("I'm sorry you haven't passed the course, you need to review the content given again.");
        }

        bool pass_class = percentage >= 70;
    }
}