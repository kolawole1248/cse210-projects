using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> Products { get; set; } = new List<Product>();
    public Customer Customer { get; set; }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalOrderCost()
    {
        double totalCost = 0;

        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }

        return totalCost + (Customer.IsInUSA() ? 5 : 35);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (var product in Products)
        {
            packingLabel += $"Name: {product.Name}, ProductId: {product.ProductId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return Customer.Address.GetFullAddress();
    }
}
