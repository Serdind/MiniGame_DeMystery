public class Quest
{
    public int ID;
    public string Name;
    public string Description;

    public Quest(int id, string name, string description)
    {
        ID = id;
        Name = name;
        Description = description;
    }

    public static void GetQuest(Player player)
    {
        for (int i = 0; i < World.Quests.Count; i++)
        {
            if (player.CurrentLocation == "F")
            {
                if (World.Quests[i].Name == "Clear the farmer's field")
                {
                    Console.WriteLine("“I can't w'rk mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?”");
                    Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}.\n--------------------------------\n{World.Quests[i].Description}\nPress y to accept: ");
                    string anwserQuest = Console.ReadLine();

                    if (anwserQuest.ToLower() == "y")
                    {
                        Console.WriteLine("You have accepted the quest. Go to Farmer's field(V).");
                        player.playerQuests.Add(World.Quests[i]);
                        //Player movement
                    }
                    else
                    {
                        Console.WriteLine("You did not accept the quest. Try again.");
                        GetQuest(player);
                    }
                }
            }
            else if (player.CurrentLocation == "A")
            {
                if (World.Quests[i].Name == "Clear the alchemist's garden")
                {
                    Console.WriteLine("“Those rats art nibbling on mine own h'rbs! I couldst very much useth an adventur'r to taketh careth of those folk …”");
                    Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}.\n--------------------------------\n{World.Quests[i].Description}\nPress y to accept: ");
                    string anwserQuest = Console.ReadLine();

                    if (anwserQuest.ToLower() == "y")
                    {
                        Console.WriteLine("You have accepted the quest. Go to Alchemist's garden(P).");
                        player.playerQuests.Add(World.Quests[i]);
                        //Player movement
                    }
                    else
                    {
                        Console.WriteLine("You did not accept the quest. Try again.");
                        GetQuest(player);
                    }
                }
            }
            else if (player.CurrentLocation == "B")
            {
                if (World.Quests[i].Name == "Collect spider silk")
                {
                    Console.WriteLine("“I shalt releaseth the town folks of their feareth!”");
                    Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}.\n--------------------------------\n{World.Quests[i].Description}\nPress y to accept: ");
                    string anwserQuest = Console.ReadLine();

                    if (anwserQuest.ToLower() == "y")
                    {
                        Console.WriteLine("You have accepted the quest. Go to Spider forest(S).");
                        player.playerQuests.Add(World.Quests[i]);
                        //Player movement
                    }
                    else
                    {
                        Console.WriteLine("You did not accept the quest. Try again.");
                        GetQuest(player);
                    }
                }
            }
        }
        if (player.CurrentLocation == "G")
        {
            Console.WriteLine("“Turn back at once, peasant! Unless thee hast proof of thy grit.”");
            if (player.questCompleted.Count == 2)
            {
                //Player movement
            }
            else
            {
                Console.WriteLine("You need to have finished the other two quests before passing the guard.");
                //Player movement
            }
        }
    }
    public static void CompleteQuest(Player player)
    {
        for (int s = 0; s < player.playerQuests.Count; s++)
        {
            if (player.CurrentLocation == "V" && player.playerQuests[s].Name == "Clear the farmer's field")
            {
                //Three snakes fight
                player.questCompleted.Add(player.playerQuests[s]);
            }
            else if (player.CurrentLocation == "P" && player.playerQuests[s].Name == "Clear the alchemist's garden")
            {
                //Three rats fight
                player.questCompleted.Add(player.playerQuests[s]);
            }
            else if (player.CurrentLocation == "S" && player.playerQuests[s].Name == "Collect spider silk")
            {
                //Spider fight
                //End
            }
            else
            {
                Console.WriteLine("You haven't accepted the quest.");
            }
        }
    }
}