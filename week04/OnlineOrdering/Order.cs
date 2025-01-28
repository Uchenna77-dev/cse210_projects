using System;

class Order {
private List<Product> Products;
    private Customer OrderCustomer;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        OrderCustomer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = OrderCustomer.LivesInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"- {product.GetPackingLabel()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{OrderCustomer.GetShippingLabel()}";
    }
}
