using System;
using System.Text;

public class Word
{
    private readonly string _raw;   
    private bool _revealed = true;

    public Word(string raw)
    {
        _raw = raw;
    }

    public bool IsHidden => !_revealed;

    public void Hide()
    {
        _revealed = false;
    }

    public void Reveal()
    {
        _revealed = true;
    }

    
    public string Display()
    {
        if (_revealed) return _raw;

        var sb = new StringBuilder(_raw.Length);
        foreach (char c in _raw)
        {
            sb.Append(char.IsLetter(c) ? '_' : c);
        }
        return sb.ToString();
    }
}
