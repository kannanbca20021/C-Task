using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = CalculateSum(numbers);
        Console.WriteLine("The sum of all elements in the array is: " + sum);
    }

    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
    }
}
