using System;
using System.Collections.Generic;

public class Scripture
{
    // Private field to store the reference of the scripture
    private Reference _reference;

    // Private list to store the words of the scripture
    private List<Word> _words;

    // Random object for selecting words to hide
    private Random _random;

    // Constructor to initialize the scripture with its reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and add them to the list
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

        // Initialize the random object
        _random = new Random();
    }

    // Method to hide a specified number of random words
    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            // Select a random index and hide the word at that index
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden()) return false; // Return false if any word is not hidden
        }
        return true; // All words are hidden
    }

    // Override ToString method to provide the scripture text with hidden words
    public override string ToString()
    {
        // Join the words to form the scripture text
        string scriptureText = string.Join(" ", _words.ConvertAll(word => word.GetText()));

        // Return the reference and the scripture text
        return $"{_reference}\n{scriptureText}";
    }
}
