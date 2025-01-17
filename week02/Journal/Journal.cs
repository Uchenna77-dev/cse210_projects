using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry _entryText)
    {
        _entries.Add(_entryText);
    }

    public void DisplayJournal()
    {
        foreach (Entry _entryText in _entries)
        {
            _entryText.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry _entryText in _entries)
            {
                writer.WriteLine($"{_entryText._date},{_entryText._promptText},{_entryText._entryText},{_entryText._mood},{_entryText._location}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 5)
                {
                    Entry _entryText = new Entry(parts[0], parts[1], parts[2], parts[3], parts[4]);
                    _entries.Add(_entryText);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
