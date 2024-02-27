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
            if (player.CurrentLocation.Name == "Farmhouse")
            {
                if (World.Quests[i].Name == "Clear the farmer's field")
                {
                    if (player.playerQuests.Contains(World.Quests[i]))
                    {
                        player.Movement(player);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else
                    {
                        Console.WriteLine("“I can't w'rk mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?”");
                        Thread.Sleep(1000);
                        Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}\n{World.Quests[i].Description}\n--------------------------------\nPress Y to accept: ");
                        string anwserQuest = Console.ReadLine();

                        if (anwserQuest.ToLower() == "y")
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("You have accepted the quest. Go to Farmer's field(V).");
                            Thread.Sleep(1000);
                            player.playerQuests.Add(World.Quests[i]);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("You did not accept the quest. Try again.");
                            Thread.Sleep(1000);
                            GetQuest(player);
                        }
                    }
                }
            }
            else if (player.CurrentLocation.Name == "Alchemist's hut")
            {
                if (World.Quests[i].Name == "Clear the alchemist's garden")
                {
                    if (player.playerQuests.Contains(World.Quests[i]))
                    {
                        player.Movement(player);
                        Console.WriteLine(player.CurrentLocation.Name);
                    }
                    else
                    {
                        Console.WriteLine("“Those rats art nibbling on mine own h'rbs! I couldst very much useth an adventur'r to taketh careth of those folk …”");
                        Thread.Sleep(1000);
                        Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}\n{World.Quests[i].Description}\n--------------------------------\nPress Y to accept: ");
                        string anwserQuest = Console.ReadLine();

                        if (anwserQuest.ToLower() == "y")
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("You have accepted the quest. Go to Alchemist's garden(P).");
                            Thread.Sleep(1000);
                            player.playerQuests.Add(World.Quests[i]);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("You did not accept the quest. Try again.");
                            Thread.Sleep(1000);
                            GetQuest(player);
                        }
                    }
                }
            }
            else if (player.CurrentLocation.Name == "Bridge")
            {
                if (World.Quests[i].Name == "Collect spider silk")
                {
                    if (player.playerQuests.Contains(World.Quests[i]))
                    {
                        player.Movement(player);
                    }
                    else
                    {
                        Console.WriteLine("“I shalt releaseth the town folks of their feareth!”");
                        Thread.Sleep(1000);
                        Console.WriteLine($"--------------------------------\nQuest: {World.Quests[i].Name}\n{World.Quests[i].Description}\n--------------------------------\nPress Y to accept: ");
                        string anwserQuest = Console.ReadLine();

                        if (anwserQuest.ToLower() == "y")
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("You have accepted the quest. Go to Spider forest(S).");
                            Thread.Sleep(1000);
                            player.playerQuests.Add(World.Quests[i]);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("You did not accept the quest. Try again.");
                            Thread.Sleep(1000);
                            GetQuest(player);
                        }
                    }
                }
            }
        }
    }
    public static void CompleteQuest(Player player)
    {
        for (int s = 0; s < player.playerQuests.Count; s++)
        {
            if (player.CurrentLocation.Name == "Farmer's field" && player.playerQuests[s].Name == "Clear the farmer's field")
            {
                if (player.questCompleted.Contains(player.playerQuests[s]))
                {
                    Thread.Sleep(1000);
                    player.Movement(player);
                }
                else
                {
                    //Three snakes fight
                    player.questCompleted.Add(player.playerQuests[s]);
                }
            }
            else if (player.CurrentLocation.Name == "Alchemist's garden" && player.playerQuests[s].Name == "Clear the alchemist's garden")
            {
                if (player.questCompleted.Contains(player.playerQuests[s]))
                {
                    Thread.Sleep(1000);
                    player.Movement(player);
                }
                else
                {
                    //Three rats fight
                    player.questCompleted.Add(player.playerQuests[s]);
                }
            }
            else if (player.CurrentLocation.Name == "Forest" && player.playerQuests[s].Name == "Collect spider silk")
            {
                if (player.questCompleted.Contains(player.playerQuests[s]))
                {
                    Thread.Sleep(1000);
                    player.Movement(player);
                }
                else
                {
                    //Spider fight
                    //End
                    player.questCompleted.Add(player.playerQuests[s]);
                }
            }
        }
    }
}