public class Program
{
    static string playersName;

    public static void Main()
    {
<<<<<<< HEAD
        Console.WriteLine("Welcome to the Adventure Game!\n");

        Console.WriteLine("The people in your town are being terrorized by giant spiders.\n");

        Console.WriteLine("You decide to do what you can to help your people.\n");

        Console.Write("Enter your name: ");
        playersName = Console.ReadLine();

        Console.WriteLine($"\nWelcome, {playersName}!\n");

        Console.WriteLine("Are you ready to begin your adventure?\n");

        Console.WriteLine("Press any key to embark on your journey...");
        Console.ReadKey();

        Console.Clear();

        
=======
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
>>>>>>> get_and_complete_quests
    }
}
