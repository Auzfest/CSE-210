public class saveGoals : Goal
{
    public void Save(List<string> listOfGoals, int level, int points)
    {
        listOfGoals[0].Replace(listOfGoals[0], $"{level}|{points}");

        //prompt user for file name
        Console.Write("Type file name: ");
        string fileResponse = Console.ReadLine();

        //write entries into file
        string journalCSV = fileResponse;
        using (StreamWriter outputFile = new StreamWriter(journalCSV))
        {
            for (int entry = 0;  entry < listOfGoals.Count; entry++)
            {
                outputFile.WriteLine($"{listOfGoals[entry]}");
            }
        }
    }
}