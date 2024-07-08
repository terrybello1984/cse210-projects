// Import the System namespace for basic functionality
using System;

// Declare the Rectangle class that inherits from Shape
public class Rectangle : Shape
{
    // Declare private fields to store the length and width of the rectangle
    private double _length;
    private double _width;

    // Constructor that accepts the color, length, and width, and calls the base class constructor with the color
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length; // Set the value of the length
        _width = width;   // Set the value of the width
    }

    // Method to get the area of the rectangle, overrides the base class method
    public override double GetArea()
    {
        return _length * _width; // Calculate the area as length times width
    }
}
