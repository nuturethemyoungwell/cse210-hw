using System;

class Program
{
    static void Main(string[] args)
    {
        //create path of the file
        string pathName = @"C:\Users\User\OneDrive\Desktop\BYU\cse210-hw\Develop04\Develop04\myFile.txt";

        //Now create a file using the file name above
        FileStream fs = File.Create(pathName);

        //check whether the file was created at the file path.
        if (File.Exists(pathName))
        {
            Console.WriteLine("File created successfully");

        }
        else
        {
            Console.WriteLine("File was not created");
        }
    }
}