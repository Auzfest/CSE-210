public class Base
{
    private int UserHealthPoints;
    private int weaponDamage;
    public int BeginCombat(int counter)
    {
        if (counter == 0)
        {
           UserHealthPoints = 40;
           weaponDamage = 5; 
        }
        Combat combatsequence = new Combat();
        WeaponandHealth upgradeUser = new WeaponandHealth();
        LootRandomizer loot = new LootRandomizer();
        combatsequence.getNewEnemy();
        int endGameIfLose = 0;
        int winner = 0;
        while (winner == 0)
        {
            string stringUserWin = combatsequence.hitOrBlock(weaponDamage);
            Console.WriteLine($"its health is at {stringUserWin}!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            int userWin = int.Parse(stringUserWin);
            if (userWin <= 0)
            {
                winner = 1;
            }
            UserHealthPoints = combatsequence.EnemyhitOrBlock(UserHealthPoints);
            Console.WriteLine($"your health is at {UserHealthPoints} out of 40!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            if (UserHealthPoints <= 0)
            {
                winner = 2;
            }
        }
        if (winner == 1)
        {
            Console.WriteLine("");
            Console.WriteLine("You win!");
            Console.WriteLine("Searching for loot...");
            Thread.Sleep(1000);
            int newUpgrade = loot.randomChance();
            if (newUpgrade == 1)
            {
                Console.WriteLine("Weapon upgrade found! +1 damage!");
                weaponDamage = upgradeUser.upgradeTime(weaponDamage);
            }
            else if (newUpgrade == 10)
            {
                Console.WriteLine("Health potion found! +10 health!");
                UserHealthPoints = upgradeUser.healTime(UserHealthPoints);
            }
            else
            {
                Console.WriteLine("Better Luck next time!");
            }

            Thread.Sleep(1000);

            Console.WriteLine($"you health is at {UserHealthPoints} out of 40");
            Console.WriteLine("You got an upgrade you can either:");
            Console.WriteLine("1. Upgrade Weapon");
            Console.WriteLine("2. Replenish Health");

            Console.Write("Choose an option: ");
            string userChoice = Console.ReadLine();
            int chosenOption = int.Parse(userChoice);

            switch (chosenOption)
            {
                case 1:
                    if (weaponDamage <= 12)
                    {
                        weaponDamage = upgradeUser.upgradeTime(weaponDamage);
                    }
                    else
                    {
                        Console.WriteLine("Your weapon is maxed out!");
                    }
                    break;

                case 2:
                    UserHealthPoints = upgradeUser.healTime(UserHealthPoints);
                    break;
            }
            Console.WriteLine($"Health points: {UserHealthPoints} | Weapon damage: {weaponDamage}");
        }
        else if (winner == 2)
        {
            Console.WriteLine("You lose");
            endGameIfLose = 1;

        }
        return endGameIfLose;
    }
}