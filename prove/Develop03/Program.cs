using System;

class Program
{
    static void Main(string[] args)
    {
        string selector = "start";
        bool done;

        Reference r1 = new Reference("John", "3", "16");
        Reference r2 = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture1 = new Scripture(r2.CompileReference(), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        do
        {
            Console.Clear();

            Console.Write(r2.CompileReference() + " ");

            scripture1.DisplayScripture();
            done = scripture1.IsCompletelyHidden();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 to hide words, press 2 to show words, or type 'quit' to finish:");
            selector = Console.ReadLine();
            if (selector == "1")
            {
                scripture1.HideWords();
            }
            else if (selector == "2")
            {
                scripture1.ShowWords();
            }
        } while (selector != "quit" && done == false || selector == "2");

        // bool keepRunning = true;

        // while (keepRunning == true)
        // {
        //     Console.Clear();
        //     // string verseOfScripture = "Jacob 3:2";
        //     string fullScripture = "O all ye that are pure in heart, lift up your heads and receive the pleasing word of God, and feast upon his love; for ye may, if your minds are firm, forever.";

        //     Reference reference = new Reference("Jacob", 3, 2);
        //     Scripture scripture = new Scripture(reference, fullScripture);

        //     Console.WriteLine(scripture.GetDisplayText());

        //     Console.Write("Press enter to continue or type 'quit' to finish.");
        //     string answerOfUser = Console.ReadLine();

        //     if (answerOfUser == "quit" || scripture.IsCompletelyHidden())
        //     {
        //         keepRunning = false;
        //     }

        //     scripture.HideRandomWords(2);

        // }
    }
}