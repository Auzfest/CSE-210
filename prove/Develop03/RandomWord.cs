class RandomWords
{
    private string[] scriptureWords;
    public RandomWords()
    {

    }

    public string BlankRandomWords(string scripture)
    {
        scriptureWords = scripture.Split(" ");
        int rangeOfWords = scriptureWords.Count();

        for (int count = 0; count < 4; count++)
        {   
            Random randomGenerator = new Random();
            int randomScripture = randomGenerator.Next(0,rangeOfWords);
            string wordToReplace = scriptureWords[randomScripture];
            scriptureWords[randomScripture] = scriptureWords[randomScripture].Replace(wordToReplace,"___");
        }

        string fragmented = String.Join(" ", scriptureWords);

        return fragmented;
    }
}