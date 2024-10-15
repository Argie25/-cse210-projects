public class Customer
{
    private string _name;
    private List<Address> _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new List<Address>(); 
        _address.Add(new Address(street, city, state, country));
        
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUs()
    {
        // Check if any address in the list is in the USA
        foreach (var addr in _address)
        {
            if (addr.IsUs())
            {
                return true;  // Return true if at least one address is in the USA
            }
        }
        return false;  // Return false if no addresses are in the USA
    }

    public string FullDetails()
    {
        // Assuming you want to show the first address in the list
        return $"Customer: {_name}\nAddress: {_address[0].FullAddress()}";
    }
    
}