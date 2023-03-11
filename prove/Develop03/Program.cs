using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        int finishNumber = 0;

        DisplayScripture scripture = new DisplayScripture();

        GetScripture chosenScripture = new GetScripture();
        string chosen = chosenScripture.getRandomScripture();
        scripture.newScripture = chosen;

        string emptyChosen = " ";
        emptyChosen = chosenScripture.newEmptyScripture(chosen, emptyChosen);
        scripture.emptyScripture = emptyChosen;

        scripture.fullScripture();

        while (finishNumber != 2)
        {

            Console.Write(" 1- get rid of words / 2- end program -> ");
            string userChoice = Console.ReadLine();
            int chosenOption = int.Parse(userChoice);

            Console.Clear();

            switch(chosenOption)
            {
                case 1:
                    if (scripture.newScripture == scripture.emptyScripture)
                    {
                        Console.WriteLine("Congrats! You memorized a scripture!");
                        finishNumber += 2;
                        break;
                    }
                    else
                    {
                        scripture.fragmentScripture();
                        break;
                    }
            
                case 2:
                    finishNumber += 2;
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again. /n");
                    break;
            }

        
        }
    }
}