using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        // Grade Calculator Program

        // Core Requirements

        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        // Read user input and convert it to double
        double gradePercentage = Convert.ToDouble(Console.ReadLine());       

    
        // Declaration of the letter variable for the letter grade
        string letter;

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }    
        else if (gradePercentage >= 80)
        {
            letter = "B";        
        }    
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
    
        // Show letter grade
        Console.WriteLine("\nYour final grade is " + letter);

        // Determine if the user passed the course and display a message
        if (gradePercentage >= 70)
        {
        Console.WriteLine($"\nCongratulations! You passed the course with a {letter} grade");
        }
        else
        {
        Console.WriteLine($"\nEncorage for next time. Your grade is {letter}, and you did not pass the course");
        }

        // Stretch Challenge

        // Get the last digit
        int lastDigit = (int)gradePercentage % 10;
        string sign = "";

        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }

            // Additional logic for exceptional cases
            if (letter == "A" && lastDigit <= 3)
            {
                sign = "-";
            }
            else if (letter == "A" && lastDigit >= 7)
            {
                sign = "";
            }
        }
        // Show letter grade and sign
        Console.WriteLine($"\nYour final grade is {letter}{sign}");

    }
}