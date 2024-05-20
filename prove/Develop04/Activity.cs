public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How many seconds would you like for your session");
        // Thread.Sleep(2000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You have completed the {_name} activity, in {_duration} seconds");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("—");
        animations.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string symbol = animations[i];
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i += 1;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


    }
}