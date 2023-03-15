using System;

class Program
{
    static void Main(string[] args)
    {
        int quitNumber = 0;
        Activities activity = new Activities();

        while (quitNumber != 1)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an option: ");
            string userChoice = Console.ReadLine();
            int chosenOption = int.Parse(userChoice);

            switch (chosenOption)
            {
                case 1:
                    activity.DoBreathingActivity();
                    Console.WriteLine("Great job! Come back if you need more relaxation!");    
                    Console.WriteLine(" ");
                    break;
    
                case 2:
                    activity.DoReflectionActivity();
                    Console.WriteLine("Great job! Come back if you need more confidence!"); 
                    Console.WriteLine(" ");
                    break;

                case 3:
                    activity.DoListingActivity();
                    Console.WriteLine("Great job! Come back if you need more positivity!"); 
                    Console.WriteLine(" ");
                    break;

                case 4:
                    quitNumber = 1;
                    break;

                default:
                    Console.WriteLine("invalid option, please try again");
                    Console.WriteLine(" ");
                    break;
            }
        }
    }
}