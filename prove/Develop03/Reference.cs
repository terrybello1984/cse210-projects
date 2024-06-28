public class Reference
{
    // Private fields to store the book, chapter, and verses
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse; // Nullable to handle single verse references

    // Constructor for single verse reference
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null; // No end verse for single verse references
    }

    // Constructor for verse range reference
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Override ToString method to provide a readable reference string
    public override string ToString()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}"
            : $"{_book} {_chapter}:{_startVerse}";
    }
}
