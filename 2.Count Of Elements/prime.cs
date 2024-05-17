using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, -1, 0, 6, -4, 9, -2, 13, 17, 21 };
        Console.WriteLine("Prime numbers in the array:");
        foreach (var number in numbers)
        {
            if (IsPrime(number))
                Console.WriteLine(number);
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
