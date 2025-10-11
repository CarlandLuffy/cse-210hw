using System;
using System.Collections.Generic;
using System.IO;

// loading the file back to read old memeories 
class Journal
{
   
    public List<Entry> _entryList;

     
    public void Initialize()
    {
        _entryList = new List<Entry>();
    }

    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
    }

    public void Display()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
        }
        else
        {
            Console.WriteLine("=======");
            foreach (Entry e in _entryList)
            {
                e.Display();
                Console.WriteLine("----------");
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry e in _entryList)
            {
                writer.WriteLine($"{e._entryDateTime}|{e._givenPrompt}|{e._entryText}");
            }
        }
        // saves everything so I dont lose it smart play. 
        Console.WriteLine($"Journal saved to {fileName}");
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entryList.Clear();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry e = new Entry();
                e._entryDateTime = parts[0];
                e._givenPrompt = parts[1];
                e._entryText = parts[2];
                _entryList.Add(e);
            }
        }

        Console.WriteLine($"Loaded {_entryList.Count} entries from {fileName}");
    }
}

    
    
    
    
