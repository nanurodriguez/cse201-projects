using System;


public class Order

{
    private List<string> _products;

    private string _nameCustomer;

    private double _shippingUS;

    private double _shippingWorldwide;

    public Order(List<string> products, string nameCustomer, double shippingUS, double shippingWorldwide)
    {
        _products = products;
        _nameCustomer = nameCustomer;
        _shippingUS = shippingUS;
        _shippingWorldwide = shippingWorldwide;

    }



    public void AddProduct(Product product)
    {

    }

    public double CalculateTotalCost()
    {
        //sum of the total cost of each product plus a one time shipping cost.

        return 0;
    }

    public string DisplayPackingLabel()
    {
        //Should list the Product ID of each product in the order
        return "";
    }

    public string DisplayShippingLabel()
    {
        // should list the name and address of the customer.
        return "";
    }


}