using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("This is an excercise tracking app!");

        /*
        the app should track these 3 activities: Running, Stationary Bycicle,Swimming in the lap pool
        _date 
        _length 

        each activity should track:
        Running Class()
        _distance 
        Stationary Bycicle Class()
        _speed
        Swimming Class()
        _numberOfLaps

        Get this info:
        -Distance
        -Speed: Miles per Hour
        -The Pace :minutes per mile

        Summary in the form of:

        - 03 Nov 2022 Running(30min)
        -Distance 3.0 miles, speed 6.0 mph
        -Pace: 10.0 min per mile

    

        */
=======
        Console.WriteLine("Welcome to the Excercising App!");

        Activity activity = new Activity("31 Oct 2024", 30);
        Console.WriteLine(activity.GetSummary());

        RunningActivity runningActivity = new RunningActivity("31 Oct 2024", 30, 30);
        CyclingActivity cyclingActivity = new CyclingActivity("31 Oct 2024", 30, 30);
        SwimmingActivity swimmingActivity = new SwimmingActivity("31 Oct 2024", 30, 30);

        string runDisplay = runningActivity.GetSummary();
        string cycleDisplay = cyclingActivity.GetSummary();
        string swimDisplay = swimmingActivity.GetSummary();

        Console.WriteLine(runDisplay);
        Console.WriteLine(cycleDisplay);
        Console.WriteLine(swimDisplay);
>>>>>>> 74e517fe01170cbf8c31f20a6fc73bc78abcd970
    }
}