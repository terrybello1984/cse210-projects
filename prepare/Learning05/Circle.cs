// Import the System namespace for basic functionality
using System;

// Declare the Circle class that inherits from Shape
public class Circle : Shape
{
    // Declare a private field to store the radius of the circle
    private double _radius;

    // Constructor that accepts the color and radius, and calls the base class constructor with the color
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius; // Set the value of the radius
    }

    // Method to get the area of the circle, overrides the base class method
    public override double GetArea()
    {
        // Calculate the area using the formula pi times radius squared
        return Math.PI * _radius * _radius;
    }
}
