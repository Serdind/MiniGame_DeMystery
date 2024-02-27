public static class Program
{
    static string playersName;

    public static void Main()
    {
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

        
    }
}
