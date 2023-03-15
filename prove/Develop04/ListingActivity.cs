public class ListingActivity : Activities
{

     private List<string> listOfListingPrompts = new List<string>();


     private int totalAnswers;
    public ListingActivity()
    {
        listOfListingPrompts.Add("Who are people in your life that you love?");
        listOfListingPrompts.Add("List off your personal strengths!");
        listOfListingPrompts.Add("When are times you felt the spirit?");
        listOfListingPrompts.Add("List off your service you have done in the past!");
    }

    public string randomListingPrompts()
    {
        Random randomGenerator = new Random();
        int randomListingPrompt = randomGenerator.Next(0, 4);
        return listOfListingPrompts[randomListingPrompt];
    }

    public void listing(string listPrompt)
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine(" ");
        Console.WriteLine(listPrompt);
        Console.WriteLine(" ");
        Console.WriteLine("Write as many answers that you can think of!");
        Thread.Sleep(5000);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(30);
        DateTime time = DateTime.Now;
        do
        {
            Console.Write("answers: ");
            string userAnswer = Console.ReadLine();
            totalAnswers += 1;
            Console.WriteLine(" ");
            time = DateTime.Now;
        } while (time < futureTime);

        Console.WriteLine($"you listed {totalAnswers} things!");
    }
}