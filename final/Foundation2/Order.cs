using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string GetLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress();
        return $"{customerName}\n{customerAddress}";
    }
}