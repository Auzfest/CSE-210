using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to The Conqueror!");
        Console.WriteLine("A text based game where you upgrade and 'watch' as you fight monsters and see how many you can defeat before you die");

        Base startGame = new Base();
        GetRank rank = new GetRank();
        int quitNumber = 0;
        int counter = 0;
        while (quitNumber != 1)
        {
            Console.WriteLine("");
            Console.WriteLine("Ready to go?");
            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Quit");

            Console.Write("Choose an option: ");
            string userChoice = Console.ReadLine();
            int chosenOption = int.Parse(userChoice);

            switch (chosenOption)
            {
                case 1:
                    int endGame = startGame.BeginCombat(counter);
                    counter += 1;
                    quitNumber = endGame;
                    break;

                case 2:
                    quitNumber = 1;
                    break;
            }
        }
        Console.WriteLine($"you went through {counter} enemies! Good job!");
        rank.rank(counter);
    }
}