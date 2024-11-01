
public class SwimmingActivity : Activity
{
    private int _numberLaps;

    public SwimmingActivity(string date, int length, int numberLaps) : base(date, length)
    {
        _numberLaps = numberLaps;

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
    public override void GetNumberLaps()
    {

    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }
}