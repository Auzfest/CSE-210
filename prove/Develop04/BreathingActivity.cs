public class BreathingActivity : Activities
{
    private int chosenTime;

    public BreathingActivity()
    {

    }
    public int BreathingTime()
    {
        do
        {

        Console.WriteLine("In this activity we will breath in and out slowly to relax and clear the mind.");
        Console.WriteLine("Each breathe in and out takes about 7 seconds each, meaning minimum time allowed is 7 seconds.");
        Console.Write("How many seconds would you like your session to be?:");
        string userBreathingChoice = Console.ReadLine();
        chosenTime = int.Parse(userBreathingChoice);
        if (chosenTime < 7)
        {
            Console.WriteLine("");
            Console.WriteLine("Must be 7 seconds or longer please try again.");
            Console.WriteLine("");
        }

        } while (chosenTime < 7);

        return chosenTime;

    }

        public void Breathing(int totalTime)
    {
        Console.WriteLine("Lets begin breathing.");
        int totalBreathes = totalTime / 3;

        string breathe = "Breath in";

        for (int counter = 0; counter < totalBreathes; counter++)
        {
            Console.WriteLine("");
            Console.Write(breathe);
            Console.WriteLine("");

            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            if (breathe == "Breath in")
            {
                breathe = "Breath out";
            }
            else if (breathe == "Breath out")
            {
                breathe = "Breath in";
            }


        }
    }
}