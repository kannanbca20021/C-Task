using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 5 };
        double mean = CalculateMean(numbers);
        double median = CalculateMedian(numbers);
        int mode = CalculateMode(numbers);
        
        Console.WriteLine("The mean of the array is: " + mean);
        Console.WriteLine("The median of the array is: " + median);
        Console.WriteLine("The mode of the array is: " + mode);
    }

    static double CalculateMean(int[] array)
    {
        int sum = array.Sum();
        return (double)sum / array.Length;
    }

    static double CalculateMedian(int[] array)
    {
        Array.Sort(array);
        int n = array.Length;
        if (n % 2 == 0)
        {
            return (array[n / 2 - 1] + array[n / 2]) / 2.0;
        }
        else
        {
            return array[n / 2];
        }
    }

    static int CalculateMode(int[] array)
    {
        var frequency = new Dictionary<int, int>();

        foreach (int number in array)
        {
            if (frequency.ContainsKey(number))
            {
                frequency[number]++;
            }
            else
            {
                frequency[number] = 1;
            }
        }

        int mode = array[0];
        int maxCount = 0;

        foreach (var pair in frequency)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mode = pair.Key;
            }
        }

        return mode;
    }
}
