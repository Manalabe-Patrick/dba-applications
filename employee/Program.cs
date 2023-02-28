using System;

class Program
{
    static void Main(string[] args)
    {
        // ask for user input
        Console.Write("Enter the number of newly hired male employees: ");
        int numMaleNew = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of newly hired female employees: ");
        int numFemaleNew = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of male permanent employees: ");
        int numMalePerm = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of female permanent employees: ");
        int numFemalePerm = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of male employees resigned: ");
        int numMaleResigned = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of female employees resigned: ");
        int numFemaleResigned = int.Parse(Console.ReadLine());

        // calculate total number of employees
        int totalNew = numMaleNew + numFemaleNew;
        int totalPerm = numMalePerm + numFemalePerm;
        int totalResigned = numMaleResigned + numFemaleResigned;

        // calculate percentage of each category
        double percentMaleNew = ((double)numMaleNew / totalNew) * 100;
        double percentFemaleNew = ((double)numFemaleNew / totalNew) * 100;
        double percentMalePerm = ((double)numMalePerm / totalPerm) * 100;
        double percentFemalePerm = ((double)numFemalePerm / totalPerm) * 100;
        double percentMaleResigned = ((double)numMaleResigned / totalResigned) * 100;
        double percentFemaleResigned = ((double)numFemaleResigned / totalResigned) * 100;

        // display the results with formatting
        Console.WriteLine("\n\nTotal number of newly hired employees: {0}", totalNew);
        Console.WriteLine("Percentage of male newly hired employees: {0:F2}%", percentMaleNew);
        Console.WriteLine("Percentage of female newly hired employees: {0:F2}%", percentFemaleNew);

        Console.WriteLine("\nTotal number of permanent employees: {0}", totalPerm);
        Console.WriteLine("Percentage of male permanent employees: {0:F2}%", percentMalePerm);
        Console.WriteLine("Percentage of female permanent employees: {0:F2}%", percentFemalePerm);

        Console.WriteLine("\nTotal number of resigned employees: {0}", totalResigned);
        Console.WriteLine("Percentage of male resigned employees: {0:F2}%", percentMaleResigned);
        Console.WriteLine("Percentage of female resigned employees: {0:F2}%", percentFemaleResigned);
    }
}