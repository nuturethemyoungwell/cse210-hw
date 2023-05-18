using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string pathName = @"C:\Users\User\OneDrive\Desktop\BYU\cse210-hw\Develop04\Develop04\myFile.txt";
        File.WriteAllText(pathName, "The type the scripture you just learnt");

        Reference scriptureReference = new Reference("Jeremiah 13:", "15", "16", "17");
        Scripture scripture  = new Scripture(scriptureReference, "People of Israel, the Lord has spoken! Be humbele and listen to him. Honour" +
        " the Lord your God, before he brings darkness, and you stamble on the mountains; before he turns into deep darkness the light you hoped" + 
        "for. if you will not listen, I will cry out in secret because of your pride; I will cry bitterly, and my tears will flow" +
        " because the Lord's people have been taken away as captives.");

        string userInput = "";
        string userWord = "";
        while (userInput != "quit" && userWord != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine();
            scripture.RemoveWords();

            //clear the console
            Console.Clear();

            //display the user quotation
           // Console.WriteLine(userWord);

            //read or collect user quotation
            userWord = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine();
        }

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Hopefully you memorized the scripture.");
    }
}