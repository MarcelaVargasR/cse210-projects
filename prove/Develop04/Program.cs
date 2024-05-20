using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (keepRunning == true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string option = Console.ReadLine();
            int menuOpcion = int.Parse(option);

            if (menuOpcion == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 60);
                breathingActivity.Run();


            }
            else if (menuOpcion == 2)
            {
                ReflectionActivity reflectingActivity = new ReflectionActivity("Reflection Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 60);
                reflectingActivity.Run();
            }
            else if (menuOpcion == 3)
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 60);
                listingActivity.Run();
            }
            else if (menuOpcion == 4)
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }

        }
    }

}