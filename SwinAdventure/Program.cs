using System;

namespace SwinAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //get player name and desc from user
            Console.Write("Enter Your Name: ");
            string playerName = Console.ReadLine();
            Console.Write("Enter Player Description: ");
            string playerDescription = Console.ReadLine();
            Player player = new Player(playerName, playerDescription);
            //create two items and add to player inventory
            Item sword = new Item(new string[] { "sword", "blade" }, "a sword", "This is a sword");
            Item shield = new Item(new string[] { "shield", "buckler" }, "a shield", "This is a shield");
            player.Inventory.Put(sword);
            player.Inventory.Put(shield);
            //create a bag and add to player inventory
            Bag bag = new Bag(new string[] { "bag", "sack" }, "a bag", "This is a bag");
            player.Inventory.Put(bag);
            //create another item and add it to the bag
            Item potion = new Item(new string[] { "potion", "vial" }, "a potion", "This is a potion");
            bag.Inventory.Put(potion);
            //loop reading command from the user, and getting the look command to execute them.
            string command = "";
            //print "Welcome to SwinAdventure!" at the start of the game.
            Console.WriteLine("Welcome to SwinAdventure!");
            while (command != "quit")
            {
                Console.Write("Command -> ");
                command = Console.ReadLine();
                string[] commandArray = command.Split(' ');
                //check the first word of the command, it will create different command objects
                switch(commandArray[0])
                {
                    case "look":
                        //create a new look command
                        LookCommand look = new LookCommand();
                        //execute the command
                        Console.WriteLine("\n" + look.Execute(player, commandArray));
                        break;
                    case "quit":
                        Console.WriteLine("Bye!");
                        return;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
    }
}
