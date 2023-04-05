public class WeaponandHealth
{
    public int upgradeTime(int weaponDamage)
    {
        weaponDamage += 1;
        return weaponDamage;
    }
    public int healTime(int UserHealthPoints)
    {   if (UserHealthPoints < 20)
        {
            UserHealthPoints += 15;
        }
        else 
        {
            UserHealthPoints += 10;
        }
        return UserHealthPoints;
    }
    public int depleteHealth(int healthPoints, string totalHitpointsTaken)
    {
        int hitpointsToTake = int.Parse(totalHitpointsTaken);
        healthPoints = healthPoints - hitpointsToTake;
        return healthPoints;
    }
}