using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        
        int[] arr = { 5, 1, 4, 6, 7, 3, 5, 7, 3 };


        //get dupplicate values from the array
        var duplicates = arr.GroupBy(x => x)
                            .Where(group => group.Count() > 1)
                            .Select(group => group.Key);

        if (duplicates.Count() > 0)
        {
            Console.WriteLine("Duplicate keys: " + string.Join(", ", duplicates));
        }
        else
        {
            Console.WriteLine("No duplicate keys found.");
        }
    }
}