public class Program
{
    public static void Main()
    {
        Location CurrentLocation = null;
        Weapon CurrentWeapon = null;

        for (int i = 0; i < World.Locations.Count; i++)
        {
            if (World.Locations[i].Name == "Home")
            {
                for (int s = 0; s < World.Weapons.Count; s++)
                {
                    if (World.Weapons[i].Name == "Rusty sword")
                    {
                        CurrentLocation = World.Locations[i];
                        CurrentWeapon = World.Weapons[i];
                    }
                }
            }
        }
        Player player = new Player("Player", CurrentLocation, CurrentWeapon,1,1);
        Console.WriteLine(CurrentLocation.Compass());
        player.Movement(player);
    }
}