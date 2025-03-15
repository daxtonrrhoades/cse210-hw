using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} {entry._promptText} {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader userFile = new StreamReader(file))
        {
            string line;
            while ((line = userFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}