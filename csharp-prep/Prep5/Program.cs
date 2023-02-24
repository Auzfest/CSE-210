using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int fav_num = PromptUserNumber();
        int square_num = SquareNumber(fav_num);
        DisplayResult(name, fav_num, square_num);

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter you name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber ()
        {
            Console.Write("Enter your favorite number:");
            string fav_num_input = Console.ReadLine();
            int fav_num = int.Parse(fav_num_input);
            return fav_num;
        }

        static int SquareNumber (int fav_num)
        {
            int square_num = fav_num * fav_num;
            return square_num;
        }
        static void DisplayResult (string name, int fav_num, int square_num)
        {
            Console.WriteLine($"Hello {name}, the square of your favorite number {fav_num} is {square_num}");
        }
    }
}