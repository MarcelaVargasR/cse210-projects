using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(45, 5);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(70, 20);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(30, 30);
        activitiesList.Add(swimming);


        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}