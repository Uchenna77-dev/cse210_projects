class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string Name, string ProductId, double Price, int Quantity)
    {
        _name = Name;
        _productId = ProductId;
        _price = Price;
        _quantity = Quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }
}
