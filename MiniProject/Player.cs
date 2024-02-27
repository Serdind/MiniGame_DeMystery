public class Player
{
    public string Name;
    public Location CurrentLocation;
    public Weapon CurrentWeapon;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public List<Quest> playerQuests = new();
    public List<Quest> questCompleted = new();

    public Player(string name, Location currentLocation, Weapon currentWeapon, int currentHitPoints, int maximumHitPoints)
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
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Current location: {player.CurrentLocation.Name}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Direction(N/E/S/W): \nQ) Quit");
                    string direction = Console.ReadLine();
                    Thread.Sleep(1000);

                    if (direction.ToLower() == "q")
                    {
                        Console.WriteLine("You have succesfully quit the program.");
                        Environment.Exit(0);
                    }
                    else if (player.CurrentLocation.Name == "Home" && direction.ToLower() == "n")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToNorth);
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "n")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToNorth);
                        Quest.GetQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "e")
                    {
                        Console.WriteLine("“Turn back at once, peasant! Unless thee hast proof of thy grit.”");
                        Thread.Sleep(1000);
                        if (player.questCompleted.Count == 2)
                        {
                            for (int s = 0; s < World.Weapons.Count; s++)
                            {
                                if (World.Weapons[i].Name == "Club")
                                {
                                    player.CurrentWeapon = World.Weapons[i];
                                }
                            }
                            Console.WriteLine($"You have aquired a new weapon: {player.CurrentWeapon.Name}");
                            Thread.Sleep(1000);
                            player.TryMoveTo(player.CurrentLocation.LocationToEast);
                        }
                        else
                        {
                            Console.WriteLine("You need to have finished the other two quests before passing the guard.");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "s")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToSouth);
                    }
                    else if (player.CurrentLocation.Name == "Town square" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                        Quest.GetQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Farmhouse" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                    }
                    else if (player.CurrentLocation.Name == "Farmhouse" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                        Quest.CompleteQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Farmer's field" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                    }
                    else if (player.CurrentLocation.Name == "Alchemist's hut" && direction.ToLower() == "n")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToNorth);
                        Quest.CompleteQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Alchemist's hut" && direction.ToLower() == "s")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToSouth);
                    }
                    else if (player.CurrentLocation.Name == "Alchemist's garden" && direction.ToLower() == "s")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToSouth);
                    }
                    else if (player.CurrentLocation.Name == "Guard post" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                    }
                    else if (player.CurrentLocation.Name == "Guard post" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                        Quest.GetQuest(player);
                    }
                    else if (player.CurrentLocation.Name == "Bridge" && direction.ToLower() == "w")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToWest);
                    }
                    else if (player.CurrentLocation.Name == "Bridge" && direction.ToLower() == "e")
                    {
                        player.TryMoveTo(player.CurrentLocation.LocationToEast);
                        Quest.CompleteQuest(player);
                    }
                    else
                    {
                        Console.WriteLine("You can`t go this way.");
                        Thread.Sleep(1000);
                        continue;
                    }
                }
            }
            if (player.questCompleted.Count != 3)
            {
                Console.WriteLine(player.CurrentLocation.Compass());
                Thread.Sleep(1000);
            }
        }
    }
    
    public void Regenerate()
    {
        double regeneration = MaximumHitPoints * 1.2;
        CurrentHitPoints += Convert.ToInt32(regeneration);
        Console.WriteLine($"You now have {CurrentHitPoints} Health");
    }

    public void FullHeal()
    {
        CurrentHitPoints = MaximumHitPoints;
        Console.WriteLine($"You are back to max health");
    }
}