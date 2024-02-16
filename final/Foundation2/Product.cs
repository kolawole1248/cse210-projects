public class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double CalculateTotalCost()
    {
        return Price * Quantity;
    }
}
