public class Fights
{
    public void FarmersField()
    {
        Console.WriteLine($"You entered the Farmer's field, where you came face to face with three snakes. \nWith your {Player.CurrentWeapon} you easily killed the first snake. When the second snake came at you, he bit you.");
        Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Fight the snakes \n3. Quit");

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine($"Current location: {Player.CurrentLocation}, weapon: {Player.CurrentWeapon}, hp: {Player.CurrentHitPoints}");
        }
        else if (answer == 2)
        {
            Console.WriteLine("The first two snakes went down but the last one attacked you.");
            Player.CurrentHitPoints -= 2;
            Console.WriteLine($"The snake did 2 points of damage! \nYou have {Player.CurrentHitPoints} of 10 HP left");
            Console.WriteLine($"Eventually you did manage to kill the last snake. \nYou completed the quest! The farmer gave you some apples.");
        }
        else if (answer == 3)
        {
            quit();
        }
    }

    public void AlchemistGarden()
    {
        Console.WriteLine($"You entered the alchemist's garden. There were rats all over the place. To save the herbs you can choose to scare the rats away or kill them all.");
        Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Scare the rats away \n3. Fight the rats \n4. Quit");

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine($"Current location: {Player.CurrentLocation}, weapon: {Player.CurrentWeapon}, hp: {Player.CurrentHitPoints}");
        }
        else if (answer == 2)
        {
            Console.WriteLine($"You tried to scare all the rats away and most of them ran away. When there were only three rats remaining you quickly killed them with {Player.CurrentWeapon}");
            Console.WriteLine("You completed the quest! You got some herbs from the alchemist.");
        }
        else if (answer == 3)
        {
            Console.WriteLine($"You killed all the rats with your {Player.CurrentWeapon}. You completed the quest! The alchemist gave you some herbs.");
        }
        else if (answer == 4)
        {
            quit();
        }
    }

    public void GuardsPost()
    {
        Console.WriteLine("Guard: “Turn back at once, peasant! Unless thee hast proof of thy grit.” You showed him proof of ”thy grit”. So the apple from the farmer's field and the herbs from the alchemist's garden.");
        Console.WriteLine("The guard let you pass the post.");
    }

    public void SpiderSilk()
    {
        Console.WriteLine("You're nearing the bridge to enter the forest. ");
        Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Enter the forest \n3. Quit");

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine($"Current location: {Player.CurrentLocation}, weapon: {Player.CurrentWeapon}, hp: {Player.CurrentHitPoints}");
        }
        else if (answer == 2)
        {
            Console.WriteLine("You're nearing the bridge to enter the forest. Suddenly, you find yourself entangled in sticky spider silk!");
            Console.WriteLine("Some giant spiders descend from the trees, ready to attack.");
            Console.WriteLine("What would you like to do (Enter a number)? \n1. See game stats \n2. Fight the spiders \n3. Try to break free from the silk \n4. Quit");

            int spiderAnswer = Convert.ToInt32(Console.ReadLine());

            if (spiderAnswer == 1)
            {
                Console.WriteLine($"Current location: {Player.CurrentLocation}, weapon: {Player.CurrentWeapon}, hp: {Player.CurrentHitPoints}");
            }
            else if (spiderAnswer == 2)
            {
                Console.WriteLine("You engage in combat with the spiders, with your weapon. After a fierce battle, you win!");
                Console.WriteLine("You did it!.");
            }
            else if (spiderAnswer == 3)
            {
                Console.WriteLine("You struggle to break free from the spider silk, but it holds you firmly in place.");
                Console.WriteLine("Unfortunately, you were unable to break free from the silk, and the spider strikes, you lose.");
                quit();
            }
            else if (spiderAnswer == 4)
            {
                quit();
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
        else if (answer == 3)
        {
            quit();
        }
    }
}
 