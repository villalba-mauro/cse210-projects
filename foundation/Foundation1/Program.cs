using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // generador de números aleatorios
        Random random = new Random();

        // Listas de nombres y comentarios predeterminados
        List<string> nombres = new List<string>
        {
            "Carlos", "Laura", "María", "Jose", "Luis", "Sofía",
            "Daniela", "Manuel", "Ana", "Pedro", "Juan", "Marta",
            "Lucía", "Miguel", "Elena", "Raúl", "Paula", "Fernando"
        };

        

        List<string> comentarios = new List<string>
        {
            "Very good video!",
            "It helped me a lot, thank you.",
            "Good job, keep it up.",
            "Excellent explanation.",
            "I would like more examples.",
            "Details were missing in some points.",
            "Thanks for the tips.",
            "Very helpful.",
            "Awesome content.",
            "I didn't quite understand this topic.",
            "Fantastic!",
            "You could go into more depth.",
            "Great effort.",
            "This really helps.",
            "I look forward to more videos like this.",
            "I didn't like the approach.",
            "Very clear and concise.",
            "I learned something new today!"
        };

        // Crear una lista de videos con datos fijos
        List<Video> videos = new List<Video>
        {
            new Video("How to program in C#", "Juan Pérez", 600),
            new Video("Introduction to Python", "Ana Gómez", 900),
            new Video("Productivity Tips", "Pedro Martínez", 450),
            new Video("Java Fundamentals", "Lucía Rodríguez", 800)
        };

        // Generar y agregar comentarios aleatorios a cada video
        foreach (Video video in videos)
        {
            // Decidir cuántos comentarios generar (entre 2 y 5 por video)
            int cantidadComentarios = random.Next(3, 6);

            for (int i = 0; i < cantidadComentarios; i++)
            {
                // Seleccionar un nombre y un comentario aleatorios
                string nombreAleatorio = nombres[random.Next(nombres.Count)]; // The List has 18 elements
                //Console.WriteLine(nombres[]); nombres[5] para acceder a una posicion lo hacemos mediante corchetes
                
    
                

                string comentarioAleatorio = comentarios[random.Next(comentarios.Count)];

                // Crear un nuevo comentario y agregarlo al video
                Comment comentario = new Comment(nombreAleatorio, comentarioAleatorio);
                video.AddComment(comentario);
            }
        }

        // Iterar sobre la lista de videos y mostrar la información
        foreach (Video video in videos)
        {
            Console.WriteLine($"Título: {video.Title}");
            Console.WriteLine($"Autor: {video.Author}");
            Console.WriteLine($"Duración: {video.Duration} segundos");
            Console.WriteLine($"Cantidad de comentarios: {video.GetCommentCount()}");
            Console.WriteLine("Comentarios:");
            video.DisplayComments();
            Console.WriteLine(new string('-', 50)); // Línea separadora
        }
    }
}
