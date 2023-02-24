using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("Guess my number!");
        Random randomGenerator = new Random();
        int random_num = randomGenerator.Next(1, 11);
        string success = "StillGoing";

        do{
            Console.Write("What is my number?:");
            string input = Console.ReadLine();
            int number_guess = int.Parse(input);

            if (number_guess == random_num)
            {
                Console.WriteLine("Correct!");
                success = "complete";
            }
            else if (number_guess > random_num)
            {
                Console.WriteLine("Lower!");
            }
            else if (number_guess < random_num)
            {
                Console.WriteLine("Higher!");
            }
        } while(success != "complete");
    }
}