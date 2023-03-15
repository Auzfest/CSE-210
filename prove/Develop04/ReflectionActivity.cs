public class ReflectionAcivity : Activities
{
     private List<string> listOfPrompts = new List<string>();

     private List<string> listOfQuestions = new List<string>();

    public ReflectionAcivity()
    {
        listOfPrompts.Add("Think of when you completed a hard task.");
        listOfPrompts.Add("Think of an act of service you did.");
        listOfPrompts.Add("Think of a time you went through a difficult trials.");
        listOfPrompts.Add("Think of When you did something amazing.");

        listOfQuestions.Add("How did it start it?");
        listOfQuestions.Add("How did you get through it?");
        listOfQuestions.Add("What did you learn from it?");
        listOfQuestions.Add("How did you complete it?");
    }

    public string randomPrompt()
    {
        Random randomGenerator = new Random();
        int randomPrompt = randomGenerator.Next(0, 4);
        return listOfPrompts[randomPrompt];
    }

    public void reflect(string prompt)
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.WriteLine(" ");
        Console.WriteLine(prompt);
        Console.WriteLine(" ");

        for (int count = 0; count < 4; count++)
        {
            Console.WriteLine(listOfQuestions[count]);
            Thread.Sleep(10000);
            Console.WriteLine(" ");
        }

    }
}