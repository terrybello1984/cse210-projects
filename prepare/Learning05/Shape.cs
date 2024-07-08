// Import the System namespace for basic functionality
using System;

// Declare the abstract base class Shape
public abstract class Shape
{
    // Declare a private field to store the color of the shape
    private string _color;

    // Constructor that accepts the color and sets it
    public Shape(string color)
    {
        _color = color;
    }

    // Method to get the color of the shape
    public string GetColor()
    {
        return _color;
    }

    // Method to set the color of the shape
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method to get the area, must be implemented by derived classes
    public abstract double GetArea();
}
