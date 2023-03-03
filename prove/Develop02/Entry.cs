public class Entry
{
    public Entry(string entryDate, string entryDetails, string promptQuestion)
    {
        this.entryDate = entryDate;
        this.entryDetails = entryDetails;
        this.promptQuestion = promptQuestion;
    }
    public Entry(string barSeparatedRecord)
    {
        string[] entryValues = barSeparatedRecord.Split("|", 3, StringSplitOptions.RemoveEmptyEntries);
        this.entryDate = entryValues[0];
        this.promptQuestion = entryValues[1];
        this.entryDetails = entryValues[2];
    }
    public string entryDate;

    public string entryDetails;

    public string promptQuestion;

    public string getFormattedEntry()
    {
        return $"{entryDate}|{promptQuestion}|{entryDetails}";
    }
}