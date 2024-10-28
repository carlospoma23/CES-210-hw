using System;

class Program
{
    static void Main(string[] args)
    {

        // Activities
        DateTime runningDate = new DateTime(2024, 10, 20);
        int runningMinutes = 30;
        double runningDistance = 3.0;
        Activity runningActivity = new Running(runningDate, runningMinutes, runningDistance);

        DateTime cyclingDate = new DateTime(2024, 10, 21);
        int cyclingMinutes = 45;
        double cyclingSpeed = 15.0;
        Activity cyclingActivity = new Cycling(cyclingDate, cyclingMinutes, cyclingSpeed);

        DateTime swimmingDate = new DateTime(2024, 10, 22);
        int swimmingMinutes = 30;
        int swimmingLaps = 20;
        Activity swimmingActivity = new Swimming(swimmingDate, swimmingMinutes, swimmingLaps);

        // list of activities
        List<Activity> activities = new List<Activity>
            {
                runningActivity,
                cyclingActivity,
                swimmingActivity
            };

        // show activities.
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}