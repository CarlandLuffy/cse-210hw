public class ScriptureReference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _firstVerse;
    private readonly int? _lastVerse; 
 
    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = null;
    }


    public ScriptureReference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public override string ToString()
    {
        return _lastVerse == null
            ? $"{_book} {_chapter}:{_firstVerse}"
            : $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
    }
}
