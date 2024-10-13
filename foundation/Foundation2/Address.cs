using System;


public class Address

{

    private string _streetAddress;

    private string _city;

    private string _stateProvince;

    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }


    public bool Location()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }


    }

    public string DisplayAll()
    {
        //- method returning a string = all fields together in one string(with newline characters where appropriate).
        string address = $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";

        return address;

    }


}