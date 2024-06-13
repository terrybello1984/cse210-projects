using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name, and print like James Bond
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your Name is {last}, {first} {last}");

    }
}