using System;


public class Order

{
    private List<string> _products;
    private Customer _nameCustomer;
    private Address _address;
    private int _shippingcost;

    public Order(List<string> products, Customer nameCustomer, Address address)
    {
        _products = products;
        _nameCustomer = nameCustomer;
        _address = address;

    }



    public void AddProduct()
    {

    }

    public double CalculateTotalCost()
    {
        int totalcost1 = 0;


        //sum of the total cost of each product plus a one time shipping cost.
        bool orderAddress = _address.Location();
        if (orderAddress == true)
        {
            _shippingcost = 5;
            totalcost1 = totalcost1 + _shippingcost;
        }
        else
        {
            _shippingcost = 35;
            totalcost1 = totalcost1 + _shippingcost;
        }

        return totalcost1;
    }

    public string DisplayPackingLabel()
    {
        string packingLabel = $"Customer Packing Label: {"\n"}";
        //A packing label should list the name and product id of each product in the order.
        foreach (var item in _products)
        {
            string label = item;
            packingLabel = $"{packingLabel} {label} {"\n"}";
        }
        return packingLabel;
    }


    public string DisplayShippingLabel()
    {
        // should list the name and address of the customer.
        string shippingLabel = $"Shipping Label: {"\n"} Name: {_nameCustomer.DisplayAll()} {"\n"}Address: {_address.DisplayAll()} {"\n"}";
        return shippingLabel;
    }


}