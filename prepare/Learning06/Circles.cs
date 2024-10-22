//child class

public class Circles : Shapes
{
    private double _radius = 0;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}