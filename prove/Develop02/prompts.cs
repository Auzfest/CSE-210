class Prompts
{
    List<string> prompts = new List<string>();
    public Prompts()
    {
        prompts.Add("What did you eat for dinner? ");
        prompts.Add("What made your day today? ");
        prompts.Add("Rate your day from one to ten and tell why! ");
        prompts.Add("What was the most fun thing about today? ");
        prompts.Add("What did you learn from scripture study today? ");
    }

    public string getRandom()
    {
        Random randomGenerator = new Random();
        int random_prompt = randomGenerator.Next(0, 5);
        return prompts[random_prompt];
    }
}