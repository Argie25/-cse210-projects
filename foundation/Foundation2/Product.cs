public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string product, double price, int quantity)
    {  
        _productName = name;
        _productId = product;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity; // Return total cost
    }

    public string GetProductDetails()
    {
        return $"{_productName} (ID: {_productId}) - Total Cost: ${TotalCost():F2}"; 
    }
}