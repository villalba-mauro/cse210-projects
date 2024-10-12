using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear productos para la primera orden
        List<Products> productsOrder1 = new List<Products>();
        productsOrder1.Add(new Products("Laptop", 1001, 1200m, 1));
        productsOrder1.Add(new Products("Mouse", 1002, 25m, 2));
        productsOrder1.Add(new Products("Phone", 1003, 1000, 1));

        // Crear la dirección y cliente para la primera orden
        Adress address1 = new Adress("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Crear la primera orden
        Order order1 = new Order(customer1, productsOrder1);

        // Mostrar etiquetas y costo total de la primera orden
        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.packingLabel());
        Console.WriteLine(order1.shippingLabel());
        Console.WriteLine($"Total Price: {order1.totalPrice():C}\n");
        Console.WriteLine("----------------------------------------------------------------");

        // Crear productos para la segunda orden
        List<Products> productsOrder2 = new List<Products>();
        productsOrder2.Add(new Products("Tablet", 2001, 300m, 1));
        productsOrder2.Add(new Products("Keyboard", 2002, 50m, 3));
        productsOrder2.Add(new Products("Ball", 2003, 200, 2));

        // Crear la dirección y cliente para la segunda orden
        Adress address2 = new Adress("San Luis 2500", "Rosario", "Santa Fe", "Argentina");
        Customer customer2 = new Customer("Camila", address2);

        // Crear la segunda orden
        Order order2 = new Order(customer2, productsOrder2);

        // Mostrar etiquetas y costo total de la segunda orden
        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.packingLabel());
        Console.WriteLine(order2.shippingLabel());
        Console.WriteLine($"Total Price: {order2.totalPrice():C}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Your product has been sent, thank you for your purchase.");
    }
}
