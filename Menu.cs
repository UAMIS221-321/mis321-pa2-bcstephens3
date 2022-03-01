using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class Menu
    {
        public static void MainMenu() //EXTRAS: three extra characters, three additional attacks, underdog adavantage calculation, game art/color, character bios
        {
            SkullArt.TheGreenShip();
            System.Console.WriteLine("Yo-Ho, Mateys! Welcome to Pirates of the Caribbean, At World's End!\n");
            System.Console.WriteLine("If ye brave, choose one of the following integers to play: \n\n1. Multiplayer (User vs. User)\n2. Singleplayer (User vs. AI)\n3. Character Bios\n4. Exit");
            System.Console.WriteLine();
            string userInput = Console.ReadLine();
            while(userInput != "4")
            {
                if(userInput != "1" && userInput != "2" && userInput != "3")
                {
                    Console.Clear();
                    System.Console.WriteLine("That's not a choice, matey.");
                }
                if(userInput == "1")
                {
                    System.Console.WriteLine("Multiplayer (User vs. User)");
                    PlayerVersusPlayer.Gameplay();
                }
                if(userInput == "2")
                {
                    Console.Clear();
                    System.Console.WriteLine("Singleplayer (User vs. AI)\n\nComing soon!");
                }
                if(userInput == "3")
                {
                    System.Console.WriteLine("\nCharacter Bios\n"); //extra: character bios
                    CharacterBios.CharacterBiosMenu();
                    Console.Clear();
                }
                // Console.Clear();
                SkullArt.TheGreenShip();
                System.Console.WriteLine("If ye brave, choose one of the following integers to play: \n\n1. Multiplayer (User vs. User)\n2. Singleplayer (User vs. AI)\n3. Character Bios\n4. Exit");
                userInput = Console.ReadLine();
            }
        }
    }
}