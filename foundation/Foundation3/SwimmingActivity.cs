<<<<<<< HEAD
//Swimming activity- Child

using System.Diagnostics;

public class SwimmingActivity : Activity
{
    
=======

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
>>>>>>> 74e517fe01170cbf8c31f20a6fc73bc78abcd970
}