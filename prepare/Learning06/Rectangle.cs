
//child Class

public class Rectangle : Shapes

{
    private double _lenght = 0;
    private double _width = 0;

    public double GetLenght()
    {
        return _lenght;
    }

    public void SetLenght(double lenght)
    {
        _lenght = lenght;
    }

    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }

    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width = width;
    }

    public override double GetArea()
    {
        return _lenght * _width;
    }
}



/* HOMEWORK EXAMPLE:

public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked = 0;

    public float GetPayRate()
    {
        return _payRate;
    }

    public void SetPayRate(float payRate)
    {
        _payRate = payRate;
    }

    public float GetHoursWorked()
    {
        return _hoursWorked;
    }

    public void SetHoursWorked(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }

    //method from parent class

    public override float GetPay()
    {
        return _hoursWorked * _payRate;
    }
}

*/