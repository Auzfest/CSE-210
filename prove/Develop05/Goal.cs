public class Goal
{
    private string newGoal;

    private int points;

    private List<string> listOfGoals = new List<string>();

    private int level;

    public Goal()
    {

    }
    public void makeNewGoal()
    {
        if (listOfGoals.Count == 0)
        {
            listOfGoals.Insert(0, $"{level}|{points}");
        }
        Console.Write("What is your goal?: ");
        string goalChoice = Console.ReadLine();
        Console.Write("describe it: ");
        string descriptionChoice = Console.ReadLine();
        Console.Write("How many points is it worth?: ");
        string pointsChoice = Console.ReadLine();

        newGoal = string.Format($"{goalChoice} | {descriptionChoice}");
        listOfGoals.Add(newGoal);
        listOfGoals.Add(pointsChoice);
    }

    public virtual void displayListOfGoals()
    {
        foreach(string goal in listOfGoals)
        {
            Console.WriteLine(goal);
        }
    }

    public void SaveAGoal()
    {
        saveGoals save = new saveGoals();
        save.Save(listOfGoals, level, points);
    }

    public void LoadAGoal()
    {
        loadGoals load = new loadGoals();
        load.Load(listOfGoals);

        string[] parts = listOfGoals[0].Split("|");

            string stringlLevel = parts[0];
            level = int.Parse(stringlLevel);
            string stringPoints = parts[1];
            points = int.Parse(stringPoints);        
    }

    public void recordEvent()
    {
        Console.WriteLine("");
        displayListOfGoals();
        Console.WriteLine("");
        Console.Write("Which goal have you completed?: ");
        string goalCompletedChoice = Console.ReadLine();
        int goalCompletedOption = int.Parse(goalCompletedChoice) * 2;

        int newPoints = int.Parse(listOfGoals[goalCompletedOption]);
        points += newPoints;
        int dividedPoints = points / 500;
        level += dividedPoints;

        listOfGoals[0] = $"{level}|{points}";
        listOfGoals[goalCompletedOption] = "COMPLETE";

    }
}