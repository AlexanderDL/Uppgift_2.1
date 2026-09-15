using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur långt hoppade Elin?");
        double elin = double.Parse(Console.ReadLine());

        Console.WriteLine("Hur långt hoppade Alma?");
        double alma = double.Parse(Console.ReadLine());

        double skillnad = elin - alma;

        Console.WriteLine("Elin hoppade " + skillnad + " meter längre.");
    }
}
