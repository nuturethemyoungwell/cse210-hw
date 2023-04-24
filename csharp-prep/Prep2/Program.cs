using System;

class Program
{
    static void Main(string[] args)
     {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradepercent = int.Parse(grade);

        string letter = "";
        

        if (gradepercent >= 97)
        {
            letter = "A+";
        }
        else if (gradepercent >= 90)
        {
            letter = "A";
        }

        else if (gradepercent >= 80)
        {
            letter = "B";
        }

        else if (gradepercent >= 70)
        {
            letter = "C";
        }
        else if (gradepercent >= 60)
        {
            letter = "D";
        }

        

        else
        {
            letter = "F";
        }

    
        Console.WriteLine($"congrat your grade is {letter}");

        if (gradepercent >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Better luck next time!");
        }
        
    }
}