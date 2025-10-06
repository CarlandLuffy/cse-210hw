class Journal
{
    // attribute 
    public List<Entry> _entryList;
    // behaviors 

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
        Console.WriteLine("=======");
        foreach (Entry e in _entryList)
        {
            e.Display();
            Console.WriteLine("----------");
       }
    }
}