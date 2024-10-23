//Parent class

public abstract class Shapes
{
    protected string _color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public Shapes(string color)
    {
        _color = color;
    }
    public abstract double GetArea();

}




























/*
public abstract class Employee
{
    protected string _name;
    protected string _idNumber;

    public Employee()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    public void SetIdNumber(string idNumber)
    {
        _idNumber = idNumber;
    }

    public abstract float GetPay(); //this tells c# that this is something that I might override in the other classes.
    // the abstract method should be in an abstract class
    // with an empty method we can define the method in the derived classes



}

*/