public class Order
{
    private Customer _customer;
    private List<Product> _product = new List<Product>();
    private const double USA_Shipping_Cost = 5.00; // Shipping cost if customer is in the USA
    private const double International_Shipping_Cost = 35.00; // Shipping cost for international customers

    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(string productName, string productId, double price, int quantity)
    {
        _product.Add(new Product(productName, productId, price, quantity));
    }

    public double CalculateTotalCost()
    {
        double totalProductCost = 0;

        // Sum up the total cost of each product
        foreach (var product in _product)
        {
            totalProductCost += product.TotalCost(); // TotalCost returns a double
        }

        // Determine the shipping cost based on the customer's location
        double shippingCost = _customer.LivesInUs() ? USA_Shipping_Cost : International_Shipping_Cost;

        // Return total cost including shipping
        return totalProductCost + shippingCost;
    }

    // Method to generate the packing label
    public string GeneratePackingLabel()
    {
        var packingLabel = new System.Text.StringBuilder();
        packingLabel.AppendLine("Packing Label:");

        foreach (var product in _product)
        {
            packingLabel.AppendLine(product.GetProductDetails()); // Uses GetProductDetails method from Product class
        }

        return packingLabel.ToString();
    }

    // Method to generate the shipping label
    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.FullDetails()}"; // Assuming FullDetails returns the customer's details
    }
}
