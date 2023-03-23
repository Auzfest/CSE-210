public class EternalGoals : Goal
{
    private string newGoal;
    public override void makeNewGoal(int chosen, List<string> listOfGoals, int level, int points)
    {
        if (listOfGoals.Count == 0)
        {
            listOfGoals.Insert(0, $"{level}|{points}");
        }
        Console.Write("What is your goal?: ");
        string goalChoice = Console.ReadLine();
        Console.Write("describe it: ");
        string descriptionChoice = Console.ReadLine();
        Console.Write("How many points is it worth each time?: ");
        string pointsChoice = Console.ReadLine();

        newGoal = string.Format($"ETERNAL| {goalChoice} | {descriptionChoice}");
        listOfGoals.Add(newGoal);
        listOfGoals.Add(pointsChoice);
    }

    public override string recordEvent(int chosen, List<string> listOfGoals, int level, int points)
    {
        chosen += 1;
        int newPoints = int.Parse(listOfGoals[chosen]);
        points += newPoints;
        int dividedPoints = points / 500;
        level += dividedPoints;

        string newLevel = $"{level}|{points}";
        return newLevel;
    }
}