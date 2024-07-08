// Import the necessary namespaces
using System;
using System.Collections.Generic;

// Declare the main class of the program
class Program
{
    // Declare the main method of the program
    static void Main(string[] args)
    {
        // Create a list to store shapes, the data type is List<Shape>
        List<Shape> shapes = new List<Shape>();

        // Add an instance of Square to the list of shapes
        shapes.Add(new Square("Red", 4));
        
        // Add an instance of Rectangle to the list of shapes
        shapes.Add(new Rectangle("Blue", 5, 3));
        
        // Add an instance of Circle to the list of shapes
        shapes.Add(new Circle("Green", 2.5));

        // Iterate through the list of shapes
        foreach (Shape shape in shapes)
        {
            // Get and display the color of the shape
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            
            // Get and display the area of the shape
            Console.WriteLine($"Shape Area: {shape.GetArea()}");
            
            // Print a blank line to separate the output of each shape
            Console.WriteLine();
        }
    }
}
