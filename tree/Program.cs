using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user for the max row
        Console.Write("Enter the maximum number of rows: ");
        int maxRows = int.Parse(Console.ReadLine());


        //loop on the row and print it's value
        for (int i = 1; i <= maxRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}