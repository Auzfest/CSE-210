public class LootRandomizer
{

    public int randomChance()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 10);
        return randomNumber;
    }

    public int weaponUpgradeFound(int weaponDamage)
    {
        Console.WriteLine("Weapon upgrade found! +1 damage!");
        weaponDamage += 1;
        return weaponDamage;
    }

    public int HealthFound(int UserHealthPoints)
    {
        Console.WriteLine("Health potion found! +10 health!");
        UserHealthPoints += 10;
        return UserHealthPoints;
    }
}