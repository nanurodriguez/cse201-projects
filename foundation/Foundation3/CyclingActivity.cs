
public class CyclingActivity : Activity
{
    private int _speed;

    public CyclingActivity(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }
    public override void GetDistance()
    {

    }
    public override void GetSpeed()
    {

    }
    public override void GetPace()
    {

    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }
}