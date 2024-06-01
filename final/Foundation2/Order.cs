public class Order
{

    private Customer _customer;
    private List<Product> _products;


    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalShippingCost()
    {
        double shippingCost = _customer.IsCitizen() ? 5 : 35;
        return shippingCost;
    }

    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        foreach (Product product in _products)
        {
            double price = product.GetProductPrice();
            totalprice += price;
        }

        double shippingCost = TotalShippingCost();
        totalprice += shippingCost;

        return totalprice;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductName() + " - " + product.GetProductID() + "\n";
        }
        return packingLabel;
    }


    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label: " + _customer.GetName() + "\n" + _customer.GetAddress();
        return shippingLabel;
    }




    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel();
        string shippingLabel = GenerateShippingLabel();
        string totalCost = "Total cost: $" + CalculateTotalPrice();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"{totalCost:.f2}");

    }

}