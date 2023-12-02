using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress();
        return $"{customerName}\n{customerAddress}";
    }
    public decimal CalculateTotal()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        decimal shippingCost;
        if (_customer.findUSA())
        {
            shippingCost = 5;
        }
            else
        {
            shippingCost = 35;
        }
        
        return totalCost + shippingCost;
    }

    public string GetPackLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product Name: {product.GetName()} ({product.GetProductId()})\n";
        }

        return packingLabel;
    }

        public decimal ShippingTotal()
    {
        decimal shippingCost;
        if (_customer.findUSA())
        {
            shippingCost = 5;
        }
            else
        {
            shippingCost = 35;
        }
        
        return shippingCost;
    }  
}