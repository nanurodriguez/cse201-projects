//child class

public class Square : Shapes
{
    private double _side = 0;

    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

}


















/*
public class SalaryEmployee : Employee
{
    private float _salary = 0;

    public float GetSalary()
    {
        return _salary;
    }
    public void SetSalary(float salary)
    {
        _salary = salary;
    }

    public override float GetPay()
    {
        return _salary / 12;
    }

}

*/