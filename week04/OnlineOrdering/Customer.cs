using System;

class Customer
{
    private string _name;
    private Address CustomerAddress;

    public Customer(string Name, Address address)
    {
        _name = Name;
        CustomerAddress = address;
    }

    public bool LivesInUSA()
    {
        return CustomerAddress.IsInUSA();
    }

    public string GetShippingLabel()
    {
        return $"Name: {_name}\n{CustomerAddress}";
    }
}
