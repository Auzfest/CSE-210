class DisplayScripture
{
    private string splitter;
    public string newScripture = "";

    public string emptyScripture = "";

    public DisplayScripture()
    {

    }

    public void fullScripture()
    {
        Console.WriteLine($"{newScripture}");
    }

    public void fragmentScripture()
    {
        RandomWords randomWords = new RandomWords();
        string fragmentedScripture = randomWords.BlankRandomWords(newScripture);
        newScripture = fragmentedScripture;
        Console.WriteLine($"{fragmentedScripture}");
    }

}