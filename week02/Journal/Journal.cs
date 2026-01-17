using System;
using System.Collections.Generic;   
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
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
            Console.WriteLine();
        }
        
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string entryString = $"{entry._date}~{entry._promptText}~{entry._entryText}";
                outputFile.WriteLine(entryString);
            }
            
        }
        
    }
    public void LoadFromFile(string file)
    {

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }     
    }

}