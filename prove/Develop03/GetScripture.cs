class GetScripture
{
    private List<string> listOfScriptures = new List<string>();

    public GetScripture()
    {
        listOfScriptures.Add("James 1:5- If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        listOfScriptures.Add("1 Nephi 3:7- And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        listOfScriptures.Add("Helaman 5:12- And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        listOfScriptures.Add("Mosiah 24:14- And I will also ease the burdens which are put upon your shoulders, that even you cannot feel them upon your backs, even while you are in bondage; and this will I do that ye may stand as witnesses for me hereafter, and that ye may know of a surety that I, the Lord God, do visit my people in their afflictions.");
        listOfScriptures.Add("Mosiah 4:8-9- And this is the means whereby salvation cometh. And there is anone other salvation save this which hath been spoken of; neither are there any conditions whereby man can be saved except the conditions which I have told you. 9 Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend.");
    }

    public string getRandomScripture()
    {
        Random randomGenerator = new Random();
        int random_scripture = randomGenerator.Next(0, 5);
        return listOfScriptures[random_scripture];
    }

    public string newEmptyScripture(string chosen, string emptyChosen)
    {
        string[] scriptureWordsToReplace = chosen.Split(" ");
        int rangeOfWords = scriptureWordsToReplace.Count();
        for (int i = 0; i < rangeOfWords; i++)
        {
            string replacing = scriptureWordsToReplace[i];
            scriptureWordsToReplace[i] = scriptureWordsToReplace[i].Replace(replacing ,"___");
        }
        emptyChosen = String.Join(" ", scriptureWordsToReplace);;
        return emptyChosen;
    }
}