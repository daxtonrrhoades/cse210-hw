using System;

public class Product
{
    private string _prodName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string prodName, int productId, double price, int quantity)
    {
        _prodName = prodName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductCost()
    {
        return (int)_quantity * (double)_price;
    }
    
    public string GetProductName()
    {
        return _prodName;
    }

    public int GetProductID()
    {
        return _productId;
    }
}