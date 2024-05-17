using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 9, 1, 2, 3, 2, 8 };

        int? secondHighest = numbers.Distinct().OrderByDescending(n => n).Skip(1).FirstOrDefault();

        if (secondHighest.HasValue)
        {
            Console.WriteLine("The second highest number is: " + secondHighest.Value);
        }
        else
        {
            Console.WriteLine("The array does not contain enough distinct elements.");
        }
    }
}
