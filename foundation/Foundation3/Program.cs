using System;

class Program
{
   static void Main(string[] args)
    {
        // Crear objetos de cada actividad
        var activities = new List<Activity>
        {
            new Running(new (2022, 11, 3), 30, 4.8),
            new Cycling(new (2022, 11, 3), 30, 9.7),
            new Swimming(new (2022, 11, 3), 30, 20)
        };

        // Mostrar el resumen de cada actividad
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

}