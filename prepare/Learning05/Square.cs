// Import the System namespace for basic functionality
using System;

// Declare the Square class that inherits from Shape
public class Square : Shape
{
    // Declare a private field to store the side length of the square
    private double _side;

    // Constructor that accepts the color and side length, and calls the base class constructor with the color
    public Square(string color, double side) : base(color)
    {
        _side = side; // Set the value of the side length
    }

    // Method to get the area of the square, overrides the base class method
    public override double GetArea()
    {
        return _side * _side; // Calculate the area as side length times side length
    }
}
