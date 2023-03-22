public class loadGoals : Goal
{
        public void Load(List<string> listOfGoals)
    {
        //prompt user for file name
        Console.Write("Type file name: ");
        string fileResponse = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileResponse);

        foreach (string line in lines)
        {
            listOfGoals.Add(line);
        }


    }
}