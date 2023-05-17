using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Jeremiah 13:", "15", "16", "17");
        Scripture scripture  = new Scripture(scriptureReference, "People of Israel, the Lord has spoken! Be humbele and listen to him. Honour" +
        " the Lord your God, before he brings darkness, and you stamble on the mountains; before he turns into deep darkness the light you hoped" + 
        "for. if you will not listen, I will cry out in secret because of your pride; IAsyncDisposable will cry bitterly, and my tears will flow" +
        " because the Lord's people have been taken away as captives");

        string userInput = "";
        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Hopefully you memorized the scripture.");
    }
}