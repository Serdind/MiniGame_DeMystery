public class Player
{
    public string Name;
    public Location CurrentLocation;
    public string CurrentWeapon;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public List<Quest> playerQuests = new();
    public List<Quest> questCompleted = new();

    public Player(string name, Location currentLocation, string currentWeapon, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentLocation = currentLocation;
        CurrentWeapon = currentWeapon;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }

    public bool TryMoveTo(Location newLocation)
    {
        if (newLocation != null)
        {
            CurrentLocation = newLocation;
            return true;
        }
        return false;
    }

    public void Movement(Player player)
    {   
        while (player.questCompleted.Count != 3)
        {
            for (int i = 0; i < World.Locations.Count; i++)
            {
                if (World.Locations[i].Name == "Town square")
                {
                    Console.WriteLine("Direction(N/E/S/W): ");
                    string direction = Console.ReadLine();

                    if (player.CurrentLocation.Name == "Home" && direction.ToLower() == "n")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToNorth);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "n")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToNorth);
                        Console.WriteLine(player.CurrentLocation.Name);
                        Quest.GetQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "e")
                    {
                        Console.WriteLine("“Turn back at once, peasant! Unless thee hast proof of thy grit.”");
                        if (player.questCompleted.Count == 2)
                        {
                            player.TryMoveTo(player.CurrentLocation.LocationToEast);
                            Console.WriteLine(player.CurrentLocation.Name);
                        }
                        else
                        {
                            Console.WriteLine("You need to have finished the other two quests before passing the guard.");
                            continue;
                        }
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "s")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToSouth);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                        Console.WriteLine(player.CurrentLocation.Name);
                        Quest.GetQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Farmhouse" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Farmhouse" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                        Console.WriteLine(player.CurrentLocation.Name);
                        Quest.CompleteQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Farmer's field" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Alchemist's hut" && direction.ToLower() == "n")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToNorth);
                        Console.WriteLine(player.CurrentLocation.Name);
                        Quest.CompleteQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Alchemist's hut" && direction.ToLower() == "s")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToSouth);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Alchemist's garden" && direction.ToLower() == "s")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToSouth);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Guard post" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Guard post" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                        Console.WriteLine(player.CurrentLocation.Name);
                        Quest.GetQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Bridge" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else if (player.CurrentLocation.Name == "Bridge" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                        Console.WriteLine(player.CurrentLocation.Name);
                        Quest.CompleteQuest(player);
                    }
                }
            }
        }
    }
}