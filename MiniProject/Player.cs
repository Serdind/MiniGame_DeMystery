public class Player
{
    public string Name;
    public string CurrentLocation;
    public string CurrentWeapon;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public List<Quest> playerQuests = new();
    public List<Quest> questCompleted = new();

    public Player(string name, string currentLocation, string currentWeapon, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentLocation = currentLocation;
        CurrentWeapon = currentWeapon;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}