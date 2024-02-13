public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Monster(int id, string name, int maximumDamage, int currentHitPoints, string maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}