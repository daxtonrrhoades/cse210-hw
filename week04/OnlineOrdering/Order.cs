using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double productTotal = 0;

        foreach (var product in _products)
        {
            productTotal += product.GetProductCost();
        }

        double shippingCost = _customer.IsInUSA() ? 5 : 35;

        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: \n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetProductName()} ID: {product.GetProductID()} \n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetAddressString()}";
    }
}