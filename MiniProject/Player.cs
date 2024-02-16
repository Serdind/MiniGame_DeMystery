public class Player
{
    public string Name;
    public int CurrentLocation;
    public string CurrentWeapon;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Player(string name, int currentLocation, string currentWeapon, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentLocation = currentLocation;
        CurrentWeapon = currentWeapon;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}