using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Modification 1");
        Console.WriteLine($"Modification 2");
        Console.WriteLine($"Modification 3");
        
        int[] numbers = { 1, 2, 3, 4, 5 };
        try
        {
            double average = CalculateAverage(numbers);
            Console.WriteLine($"The average is: {average}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(numbers));
        }

        double sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        return sum / numbers.Length;
    }
    public static int CalculateMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(numbers));
        }
        return numbers.Max();
    }

}