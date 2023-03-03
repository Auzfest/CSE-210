using System.IO;
using System.Collections.Generic;

class Journal
{
    public List<Entry> entries = new List<Entry>();

    public Journal()
    {

    }

    public void displayJournal()
    {

        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.getFormattedEntry());
        }
    }

    public void createJournalEntry(string _date,string _prompt,string _response)
    {  
        //formats and adds to list
        entries.Add(new Entry(_date, _response, _prompt));
    }

    public void Save()
    {

        //prompt user for file name
        Console.Write("Type file name: ");
        string fileResponse = Console.ReadLine();

        //write entries into file
        string journalCSV = fileResponse;
        using (StreamWriter outputFile = new StreamWriter(journalCSV))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.getFormattedEntry());
            }
        }
    }

    public void Load()
    {
        //prompt user for file name
        Console.Write("Type file name: ");
        string fileResponse = Console.ReadLine();

        using(StreamReader reader = new StreamReader(fileResponse))
        {
        while (!reader.EndOfStream)
        {
            entries.Add(new Entry(reader.ReadLine().ToString()));
        }            
        }




    }
}