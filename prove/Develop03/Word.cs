public class Word
{
    // Private field to store the word text
    private string _text;

    // Private field to indicate if the word is hidden
    private bool _isHidden;

    // Constructor to initialize the word with its text
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Word is initially not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the text of the word, or "_____" if it is hidden
    public string GetText()
    {
        return _isHidden ? "_____" : _text;
    }
}
