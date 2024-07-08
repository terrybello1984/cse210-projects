using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("What is your firts name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your names is {lastName}, {firstName} {lastName}.");
    }
}