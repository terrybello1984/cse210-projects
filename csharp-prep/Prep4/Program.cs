using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a List of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        // Calculate the sum of the numbers in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate the average of the numbers in the list
        double average = (double)sum / numbers.Count;

        // Find the maximum number in the list
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            } 
        }

        // Sort the list of numbers
        numbers.Sort();

        // Show the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");

        // Check if there are positive numbers in the list
        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers in the list");
        }
        else
        {
            Console.WriteLine($"The Smallest positive number is: {smallestPositive}");
        }

        // Show the ordered list
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        
    }
}