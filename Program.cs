public class Program
{
    public void Main()
    {
        while (true)
        {
            Console.WriteLine("what will you do: \nmove: \nesc to quit");
            Console.ReadLine().ToUpper()
            if (choice == ("M" || "MOVE"));
            {
                Console.WriteLine("enter direction: \nNorth\nEast\nSouth\nWest");
                string direction = Console.ReadLine().ToUpper();
                player1.MoveTo(direction);
            }
            else if (choice == ("ESC"))
            {
                Console.WriteLine("quit? y/n");
                string quit = Console.ReadLine().ToUpper();
                if (quit == "Y")
                {
                    break
                }
            }
        }
    }
}