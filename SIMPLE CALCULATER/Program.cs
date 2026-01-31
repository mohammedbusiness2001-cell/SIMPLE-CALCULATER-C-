using System;
using System.Data;

class Calculator
{
    static void Main()
    {
      
        Console.Write("Operation: ");
        string input = Console.ReadLine();

        try
        {
            DataTable table = new DataTable();
            var result = table.Compute(input, "");

            Console.WriteLine("Result = " + result);
        }
        catch
        {
            Console.WriteLine("Invalid operation!");
        }

        Console.ReadKey();
    }
}
