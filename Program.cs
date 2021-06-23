using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
        int inNumber = 0;  
        int newNumber = 0;
        Console.WriteLine("Enter a Number> ");
        bool isParsable = Int32.TryParse(Console.ReadLine(),out inNumber);
         // inNumber = Console.ReadLine();
         newNumber  = ((inNumber * inNumber) + 14) - 3 ;
        Console.WriteLine($"{Environment.NewLine}new value is, {newNumber}");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);

        }
    }
}


