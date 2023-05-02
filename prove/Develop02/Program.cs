using System;

class Program
{
    static void Main(string[] args)
    {
        Journal         journal = new Journal();
        int             menuUserInput = 0;

        List<string>    menu = new List<string>
            {
                //Create menu And User input variables
                "Please select one of the following choices", 
                "1. Write", 
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do?"
            };
            //While user input is not 5
        while (menuUserInput != 5)
        {
            foreach (String menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());
        };

            //switch statement for user input
        }
    
}