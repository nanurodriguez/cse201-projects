<<<<<<< HEAD
//Base Class

public abstract class Activity
{
    private string _date;
    private double _length;

    pu


=======
using System;

public class Activity
{
    protected string _date;

    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual void GetDistance()
    {

    }
    public virtual void GetSpeed()
    {

    }
    public virtual void GetPace()
    {

    }
    public virtual void GetNumberLaps()
    {

    }

    public virtual string GetSummary()
    {
        return $"{_date},{_length} minutes";
    }
>>>>>>> 74e517fe01170cbf8c31f20a6fc73bc78abcd970
}