using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        var address1 = new Address("777 kings estate", "Abuja", "AJ", "Nigeria");
        var address2 = new Address("NO 3, banana island", "Lagos", "LG", "Nigeria");

        
        var customer1 = new Customer("Uchenna Onuorah", address1);
        var customer2 = new Customer("Rita Belenu", address2);

        
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "Elite200", 100, 2));
        order1.AddProduct(new Product("Iphone", "Pro16", 700.70, 3));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Kettle", "R30", 2500.25, 4));
        order2.AddProduct(new Product("Pots", "G50", 450.10, 2));

        
        var orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():0.00}\n");

            Console.WriteLine(new string('_', 20));
        }
    
    
    }
}