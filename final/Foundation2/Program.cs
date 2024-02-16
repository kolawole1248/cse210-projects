using System;

class OnlineOrderProgram
{
    static void Main()
    {
        // Create products
        Product product1 = new Product { Name = "Product 1", ProductId = "P1", Price = 10, Quantity = 2 };
        Product product2 = new Product { Name = "Product 2", ProductId = "P2", Price = 15, Quantity = 1 };

        // Create customer and address
        Address address = new Address { StreetAddress = "123 Main St", City = "City", StateProvince = "State", Country = "USA" };
        Customer customer = new Customer { Name = "John Doe", Address = address };

        // Create order
        Order order = new Order { Customer = customer };
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display order information
        Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}");
        Console.WriteLine($"Total Order Cost: ${order.CalculateTotalOrderCost()}");
    }
}
