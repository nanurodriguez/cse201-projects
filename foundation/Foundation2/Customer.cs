using System;


public class Customer

{
    private string _customerName;

    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool Location()
    {
        //- Method that returns whether they live in the US or not.(HINT!: this 
        //Should call a method on the address to find this.) 
        bool custLocation = _address.Location();
        return custLocation;
    }

    public string DisplayAll()
    {
        return _customerName;

    }



}