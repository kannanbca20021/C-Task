using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, -1, 0, 6, -4, 9, -2, 16, 25, 21 };
        Console.WriteLine("Perfect square numbers in the array:");
        foreach (var number in numbers)
        {
            if (IsPerfectSquare(number))
                Console.WriteLine(number);
        }
    }
    static bool IsPerfectSquare(int number)
    {
        if (number < 0)
            return false;

        int root = (int)Math.Sqrt(number);
        return root * root == number;
    }
}
