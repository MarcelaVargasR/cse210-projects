public class Product
{
    private string _productName;
    private string _productID;
    private double _productUnitPrice;
    private int _productQuantity;



    public void setProduct(string name, string ID, double unitPrice, int quanitity)
    {
        _productName = name;
        _productID = ID;
        _productUnitPrice = unitPrice;
        _productQuantity = quanitity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public double GetProductPrice()
    {
        return _productUnitPrice * _productQuantity;
    }
}