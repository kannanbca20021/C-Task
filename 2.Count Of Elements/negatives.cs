using System;

class Program
{
    static void Main()
    {
        // Sample array
        int[] numbers = { 3, -1, 0, 6, -4, 9, -2 };

        Console.WriteLine("Negative numbers in the array:");

        // Loop through the array to find negative numbers
        foreach (var number in numbers)
        {
            if (number < 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
