public class Player
{
    public string Name;
    public Location CurrentLocation;
    public Weapon CurrentWeapon;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Player(string name, Location currentLocation, Weapon currentWeapon, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentLocation = currentLocation;
        CurrentWeapon = currentWeapon;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}