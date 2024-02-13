public class Monster
{
    public int CurrentHitPoints;
    public int ID;
    public int MaximumDamage;
    public int MaximumHitPoints;
    public string Name;

    public Monster(int currentHitPoints, int id, int maximumDamage, int maximumHitPoints, string name)
    {
        CurrentHitPoints = currentHitPoints;
        ID = id;
        MaximumDamage = maximumDamage;
        MaximumHitPoints = maximumHitPoints;
        Name = name;
    }
}