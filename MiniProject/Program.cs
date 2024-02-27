public class Program
{
    public static void Main()
    {
        for (int i = 0; i < World.Locations.Count; i++)
        {
            if (World.Locations[i].Name == "Home")
            {
                for (int s = 0; s < World.Weapons.Count; s++)
                {
                    if (World.Weapons[i].Name == "Rusty sword")
                    {
                        Player player = new Player("Player", World.Locations[i], World.Weapons[i],1,1);
                        Console.WriteLine(World.Locations[i].Compass());
                        player.Movement(player);
                    }
                }
            }
        }
    }
}