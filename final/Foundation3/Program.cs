using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("230 Main St", "Phoenix", "Arizona", "85001", "United States");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Tech Innovations", "An annual on the latest in technology and innovation", "June 15, 2024", "9:00am - 5:00pm", $"{lectureAddress}", "Lecture", "Samantha Carter", 300);


        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Standard Details: ");
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Console.WriteLine();
        lecture.DisplayShortDescription();


        Address address2 = new Address("3 Main St", "Sacramento", "California", "90001", "United States");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Global Health Forum", "A gathering focused on global health challenges and solutions", "September 10, 2024", "10:00am - 4:00pm", $"{receptionAddress}", "Reception", "globalhealth@gmail.com");


        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Standard Details: ");
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();
        Console.WriteLine();
        Console.WriteLine("Short Details: ");
        Console.WriteLine();
        reception.DisplayShortDescription();



        Address address3 = new Address("123 Park Main", "Atlanta", "Georgia", "30002", "United States");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Sustainable Energy", "Advances in renewable energy", "August 1, 2024", "5:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");


        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine();
        Console.WriteLine("Short Details:");
        Console.WriteLine();
        outdoor.DisplayShortDescription();

        Console.WriteLine("---------------------------------------------------------------------------");
    }
}