using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 9, 1, 2, 3, 2, 8 };

        int? secondLowest = numbers.Distinct().OrderBy(n => n).Skip(1).FirstOrDefault();

        if (secondLowest.HasValue)
        {
            Console.WriteLine("The second lowest number is: " + secondLowest.Value);
        }
        else
        {
            Console.WriteLine("The array does not contain enough distinct elements.");
        }
    }
}
