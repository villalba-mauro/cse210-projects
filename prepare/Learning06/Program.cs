// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Crear una lista para almacenar las formas
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 4),          // Un cuadrado rojo con lado de 4 unidades
            new Rectangle("Blue", 5, 3),   // Un rectángulo azul de 5x3 unidades
            new Circle("Green", 2.5)       // Un círculo verde con radio de 2.5 unidades
        };

        // Iterar sobre la lista y mostrar el color y el área de cada forma
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}
