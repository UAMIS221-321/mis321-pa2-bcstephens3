using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class Menu
    {
        public static void MainMenu()
        {
            System.Console.WriteLine("Hello. Pick option with the following integers: \n1. Multiplayer (User vs. User)\n2. Singleplayer (User vs. AI)\n3.Exit");
            string userInput = Console.ReadLine();
            //Character[] characters = new Character[50];
            while(userInput != "3")
            {
                if(userInput != "1" && userInput != "2")
                {
                    System.Console.WriteLine("That's not a choice, matey.");
                }
                if(userInput == "1")
                {
                    System.Console.WriteLine("Multiplayer (User vs. User)");
                    PlayerVersusPlayer.Gameplay();
                }
                if(userInput == "2")
                {
                    System.Console.WriteLine("Singleplayer (User vs. AI)");
                }
                System.Console.WriteLine("Hello. Pick option with the following integers: \n1. Multiplayer (User vs. User)\n2. Singleplayer (User vs. AI)\n3.Exit");
                userInput = Console.ReadLine();
            }
        }
    }
}