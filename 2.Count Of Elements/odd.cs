using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, -1, 0, 6, -4, 9, -2 };
        Console.WriteLine("Odd numbers in the array:");
        foreach (var number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
