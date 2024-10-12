using System;


public class Address

{

    private string _streetAddress;

    private string _city;

    private string _stateProvince;

    private string _country;


    public bool Location()
    {
        //- method returning whether it is in the US or not. 
        return true;

    }

    public void DisplayAll()
    {
        //- method returning a string = all fields together in one string(with newline characters where appropriate). 
    }


}