using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Gamification Program!");
        Console.WriteLine("Choose a number corresponding to what you want to do!");

        int quitNumber = 0;
        Goal goal = new Goal();
        DifferentGoals differGoal = new DifferentGoals();

        while (quitNumber != 1)
        {
            Console.WriteLine("");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List of Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Progress");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string userChoice = Console.ReadLine();
            int chosenOption = int.Parse(userChoice);

            switch (chosenOption)
            {
                case 1:
                    Console.WriteLine("");
                    Console.Write("type the number, Is it a temporary(1) goal or eternal(2) goal?: ");
                    string tempOrEternalChoice = Console.ReadLine();
                    int tempOrEternal = int.Parse(tempOrEternalChoice);                  
                    goal.tempOrEternalCreate(tempOrEternal);
                    Console.WriteLine("Goal created!");
                    break;

                case 2:
                    Console.WriteLine("");
                    goal.displayListOfGoals();
                    Console.WriteLine("");
                    break;
                
                case 3:
                    Console.WriteLine("");
                    goal.SaveAGoal();
                    Console.WriteLine("Goals saved!");

                    break;

                case 4:
                    Console.WriteLine("");
                    goal.LoadAGoal();
                    Console.WriteLine("Goals loaded!");
                    break;

                case 5:
                    Console.WriteLine("");
                    goal.displayListOfGoals();
                    Console.WriteLine("");
                    Console.Write("Which goal have you completed?: ");
                    string goalCompletedChoice = Console.ReadLine();
                    int goalCompletedOption = int.Parse(goalCompletedChoice) * 2 - 1;
                    goal.tempOrEternalRecord(goalCompletedOption);
                    Console.WriteLine("Goal updated!");
                    break;

                case 6:

                    quitNumber = 1;
                    break;
            }
        }
    }
}