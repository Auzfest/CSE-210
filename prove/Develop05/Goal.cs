public class Goal
{
    private string newGoal;
    private int points;
    private List<string> listOfGoals = new List<string>();
    private int level;
    public Goal()
    {

    }
        public void tempOrEternalCreate(int chosen)
    {
        if (chosen == 1)
        {
            makeNewGoal(chosen, listOfGoals, level, points);
        }
        else if (chosen == 2)
        {
            EternalGoals diffGoals = new EternalGoals();
            diffGoals.makeNewGoal(chosen, listOfGoals, level, points);
        }
        else if (chosen == 3)
        {
            CheckListGoals checklistGoals = new CheckListGoals();
            checklistGoals.makeNewGoal(chosen, listOfGoals, level, points);            
        }
    }
    public virtual void makeNewGoal(int chosen, List<string> listOfGoals, int level, int points)
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

        newGoal = string.Format($"TEMPORARY | {goalChoice} | {descriptionChoice}");
        listOfGoals.Add(newGoal);
        listOfGoals.Add(pointsChoice);
    }

    public  void displayListOfGoals()
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

    public void tempOrEternalRecord(int chosen)
    {
        string[] parts = listOfGoals[chosen].Split("|");
        string whatIsIt = parts[0];
        if (whatIsIt == "ETERNAL")
        {
            EternalGoals diffGoals = new EternalGoals();
            string updatedLevel = diffGoals.recordEvent(chosen, listOfGoals, level, points);
            listOfGoals[0] = updatedLevel;
        }
        else if (whatIsIt == "TEMPORARY")
        {
            recordEvent(chosen, listOfGoals, level, points);
        }
        else if (whatIsIt == "CHECKLIST")
        {
            CheckListGoals checkGoals = new CheckListGoals();
            string updatedLevel = checkGoals.recordEvent(chosen, listOfGoals, level, points);
            listOfGoals[0] = updatedLevel;
        }

            string[] divided = listOfGoals[0].Split("|");

            string stringlLevel = divided[0];
            level = int.Parse(stringlLevel);
            string stringPoints = divided[1];
            points = int.Parse(stringPoints); 
    }
    public virtual string recordEvent(int chosen, List<string> listOfGoals, int level, int points)
    {
        chosen += 1;
        int newPoints = int.Parse(listOfGoals[chosen]);
        points += newPoints;
        int dividedPoints = points / 500;
        level += dividedPoints;

        listOfGoals[0] = $"{level}|{points}";
        listOfGoals[chosen] = "COMPLETE";
        return "";

    }
}