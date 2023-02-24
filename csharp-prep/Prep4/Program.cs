using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, when done type 0.");
        int new_number;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            new_number = int.Parse(input);
            
            numbers.Add(new_number);

        } while (new_number != 0);
        
        int sum = 0;
        int average = 0;
        int biggest_num = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (numbers[i] > biggest_num)
            {
                biggest_num = numbers[i];
            }
        }
        int total_in_list = numbers.Count;
        average = sum / total_in_list;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Biggest number int list: {biggest_num}");
    }
}