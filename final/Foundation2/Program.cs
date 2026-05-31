using System;

class Program
{
    static void Main()
    {
        Address a1 = new Address("123 Main", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("John Smith", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Laptop", 1, 800, 1));
        o1.AddProduct(new Product("Mouse", 2, 20, 2));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total: ${o1.GetTotalPrice()}");
    }
}