

public class RunningActivity : Activity
{
    private int _distance;

    public RunningActivity(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }
    public override void GetDistance()
    {

    }
    public override void GetSpeed()
    {
        double speed = _distance / base._length;
    }
    public override void GetPace()
    {

    }
    public override string GetSummary()
    {
        return $"{_date},{_length} minutes";
    }
}