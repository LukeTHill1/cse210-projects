public class Journal
{
    public List<Entry> entries;
    public Journal()
    {

    }
    public Journal(string import)
    {

    }
    public void Display()
    {

    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public string Export()
    {
        return "";
    }
}