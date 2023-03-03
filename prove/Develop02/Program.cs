using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Hello Develop02 World!");

    int quitNumber = 1;
    Journal journal = null;
    while (quitNumber != 0)
        {

            
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            string userChoice = Console.ReadLine();
            int chosenOption = int.Parse(userChoice);

            if (journal == null)
            {
                journal = new Journal();                
            }
            
            switch (chosenOption)
            {
                case 1:
                                //get date
                DateTime todaydate = DateTime.Today;
                string date = todaydate.ToString();

                //get prompt
                Prompts prompts = new Prompts();
                string prompt = prompts.getRandom();
                Console.WriteLine(prompt);

                //get user response
                Console.Write("> ");
                string response = Console.ReadLine();

                //save?
                journal.createJournalEntry(date, prompt, response);
                break;

                case 2:
                    journal.displayJournal();
                    break;

                case 3:
                    journal.Load();
                    break;
                
                case 4:
                    journal.Save();
                    break;

                case 5:
                    quitNumber = 0;
                    break;

                default:
                    Console.WriteLine("invalid option, please try again");
                    break;                        

            }
        }
    }
}