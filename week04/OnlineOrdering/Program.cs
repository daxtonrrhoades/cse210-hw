using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Xbox Series X", 1, 499.99, 1);
        Product product2 = new Product("PlayStation 5", 2, 499.99, 1);
        Product product3 = new Product("Nintendo Switch 2", 3, 449.99, 3);
        Product product4 = new Product("Steam Deck", 4, 299.99, 2);

        Address address1 = new Address("123 Sesame Street", "Sandy", "Utah", "Untied States");
        Address address2 = new Address("123 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Elmo", address1);
        Customer customer2 = new Customer("Jason Smith", address2);

        Order order1 = new Order(new List<Product> {product1, product2}, customer1);
        Order order2 = new Order(new List<Product> {product3, product4}, customer2);

        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}