
class Program
{
    static void Main(string[] args)
    {
        // Crea la referencia y la escritura
        Reference reference = new Reference("Juan", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Reference reference1 = new Reference("Proverbs",3 ,4,5);
        Scripture scripture2 = new Scripture(reference1,"Let not mercy and truth forsake thee: bind them about thy neck; write them upon the table of thine heart: So shalt thou find favour and good understanding in the sight of God and man. Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        Console.WriteLine("Chose 1 to memoryze a one verse or chose 2 if you want to memoryze more than one verse");
        string answer = Console.ReadLine();

        // Bucle para interactuar con el usuario
        while (!scripture.IsCompletelyHidden() || !scripture2.IsCompletelyHidden())
        {
            // Limpia la consola y muestra la escritura
            Console.Clear();

            if (answer == "1")
            {
                Console.WriteLine(scripture.GetDisplayText());
            }
            else
            {
                Console.WriteLine(scripture2.GetDisplayText());
            }
            
            // Pide al usuario que presione Enter o escriba "quit"
            Console.WriteLine("\nPresiona Enter para continuar o escribe 'quit' para salir.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Oculta algunas palabras aleatorias
            scripture.HideRandomWords(2);
            scripture2.HideRandomWords(2);
            
        }

        // Mensaje final
        Console.Clear();
        Console.WriteLine("Todas las palabras han sido ocultadas.");
    }
}
