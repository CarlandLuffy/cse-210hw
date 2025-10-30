using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scripture
{
    private readonly ScriptureReference _reference;
    private readonly List<Word> _words;
    private readonly Random _random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;

    
        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(w => new Word(w))
            .ToList();
    }

    public bool AllWordsHidden => _words.All(w => w.IsHidden || IsPurePunctuation(w));

  
    public string Display()
    {
        var sb = new StringBuilder();
        sb.AppendLine(_reference.ToString());
        sb.AppendLine();
        sb.Append(string.Join(' ', _words.Select(w => w.Display())));
        return sb.ToString();
    }

    public void HideRandomWords(int count)
    {
        var candidates = _words
            .Where(w => !w.IsHidden && !IsPurePunctuation(w))
            .ToList();

        if (candidates.Count == 0) return;

        int hides = Math.Min(count, candidates.Count);
        for (int i = 0; i < hides; i++)
        {
            int pick = _random.Next(candidates.Count);
            candidates[pick].Hide();
            candidates.RemoveAt(pick);
        }
    }

  
    private bool IsPurePunctuation(Word w)
    {
        
       
        string raw = w.Display(); 
        return raw.All(c => !char.IsLetter(c));
    }
}
