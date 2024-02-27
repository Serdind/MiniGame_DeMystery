using System.Globalization;

public static class Fights
{
    public static void FarmersField(Player player)
    {
        Console.WriteLine($"You entered the Farmer's field, where you came face to face with three snakes. \nWith your {player.CurrentWeapon.Name} you easily killed the first snake. When the second snake came at you, he bit you.");
        Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Fight the snakes \n3. Quit");
        Thread.Sleep(1000);

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine($"Current location: {player.CurrentLocation.Name}, weapon: {player.CurrentWeapon.Name}, hp: {player.CurrentHitPoints}");
            Thread.Sleep(1000);
            FarmersField(player);
        }
        else if (answer == 2)
        {
            Console.WriteLine("The first two snakes went down but the last one attacked you.");
            player.CurrentHitPoints -= 2;
            Console.WriteLine($"The snake did 2 points of damage! \nYou have {player.CurrentHitPoints} of 10 HP left");
            Console.WriteLine($"Eventually you did manage to kill the last snake. \nYou completed the quest! The farmer gave you some apples.");
            Thread.Sleep(1000);
        }
        else if (answer == 3)
        {
            Console.WriteLine("You have succesfully quit the program.");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }

    public static void AlchemistGarden(Player player)
    {
        Console.WriteLine($"You entered the alchemist's garden. There were rats all over the place. To save the herbs you can choose to scare the rats away or kill them all.");
        Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Scare the rats away \n3. Fight the rats \n4. Quit");
        Thread.Sleep(1000);

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine($"Current location: {player.CurrentLocation.Name}, weapon: {player.CurrentWeapon.Name}, hp: {player.CurrentHitPoints}");
            Thread.Sleep(1000);
            AlchemistGarden(player);
        }
        else if (answer == 2)
        {
            Console.WriteLine($"You tried to scare all the rats away and most of them ran away. When there were only three rats remaining you quickly killed them with {player.CurrentWeapon.Name}");
            Console.WriteLine("You completed the quest! You got some herbs from the alchemist.");
            Thread.Sleep(1000);
        }
        else if (answer == 3)
        {
            Console.WriteLine($"You killed all the rats with your {player.CurrentWeapon.Name}. You completed the quest! The alchemist gave you some herbs.");
            Thread.Sleep(1000);
        }
        else if (answer == 4)
        {
            Console.WriteLine("You have succesfully quit the program.");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }

    public static void SpiderSilk(Player player)
    {
        Console.WriteLine("You're nearing the bridge to enter the forest. ");
        Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Enter the forest \n3. Quit");
        Thread.Sleep(1000);

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine($"Current location: {player.CurrentLocation.Name}, weapon: {player.CurrentWeapon.Name}, hp: {player.CurrentHitPoints}");
            Thread.Sleep(1000);
            SpiderSilk(player);
        }
        else if (answer == 2)
        {
            Console.WriteLine("You're nearing the bridge to enter the forest. Suddenly, you find yourself entangled in sticky spider silk!");
            Console.WriteLine("Some giant spiders descend from the trees, ready to attack.");
            Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Fight the spiders \n3. Try to break free from the silk \n4. Quit");
            Thread.Sleep(1000);

            int spiderAnswer = Convert.ToInt32(Console.ReadLine());

            if (spiderAnswer == 1)
            {
                Console.WriteLine($"Current location: {player.CurrentLocation.Name}, weapon: {player.CurrentWeapon.Name}, hp: {player.CurrentHitPoints}");
                Thread.Sleep(1000);
                SpiderSilk(player);
            }
            else if (spiderAnswer == 2)
            {
                Console.WriteLine("You engage in combat with the spiders, with your weapon. After a fierce battle, you win!");
                Console.WriteLine("You did it!.");
                Thread.Sleep(1000);
            }
            else if (spiderAnswer == 3)
            {
                Console.WriteLine("You struggle to break free from the spider silk, but it holds you firmly in place.");
                Console.WriteLine("Unfortunately, you were unable to break free from the silk, and the spider strikes, you lose.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (spiderAnswer == 4)
            {
                Console.WriteLine("You have succesfully quit the program.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong input");
                Thread.Sleep(1000);
            }
        }
        else if (answer == 3)
        {
            Console.WriteLine("You have succesfully quit the program.");
            Thread.Sleep(1000);
            return;
        }
    }
}
 