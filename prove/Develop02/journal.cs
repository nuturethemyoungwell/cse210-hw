using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    //Attributes of the Journal class
    List<Entry> _entries;

    //Constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    //Create a list of journal enteries
    public void DisplayJournalEntry()
    {
        foreach (Entry entry in _entries)
        {
            entry.displayEntries();
        }
    }

    public void CreateJournalEntry()
    {
        promptGenerator prompt = new promptGenerator();
        string menuUserInput = prompt.GetRandomPrompt();

        //Get current date
        DateTime todays_date = DateTime.Now;
        string _date = todays_date.ToShortDateString();

        //Console to display the display the current date
        Console.WriteLine(menuUserInput);

        //Promt and record details of user input here
        Console.Write("Response: ");
        string userResponse = Console.ReadLine();

        Entry _entry = new Entry(_date, menuUserInput, userResponse);

        //Record entries
        _entries.Add(_entry);
    }

    public void SaveToCSV()
    {
        string fileName = "myFile.text";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //Add text to the file
            outputFile.WriteLine();
            
        }
    }

    public void LoadFromCSV()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
    }
}