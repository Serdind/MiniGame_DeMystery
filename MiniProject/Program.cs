public class Program
{
    public static void Main()
    { 
        for (int i = 0; i < World.Locations.Count; i++)
        {
            if (World.Locations[i].Name == "Home")
            {
                Player player = new Player("Serdin", World.Locations[i], "Sword",1,1);

                player.Movement(player);
            }
        }
    }
}