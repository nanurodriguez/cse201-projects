using System;


public class Product

{

    private string _productName;
    private int _productId;

    private double _productCost;

    private int _quantity;

    public Product(string productName, int productID, double productCost, int quantity)
    {
        _productName = productName;
        _productId = productID;
        _productCost = productCost;
        _quantity = quantity;
    }

    public double GetTotalCost(double productCost, int quantity)
    {
        //- Total product Cost: price per unit * quantity of each product.
        return productCost * quantity;
    }


    public void DisplayAll()
    {

    }


}