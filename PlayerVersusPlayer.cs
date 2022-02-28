using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class PlayerVersusPlayer //EXTRAS: three extra characters, three additional attacks, underdog adavantage calculation
    {
        public static void Gameplay()
        {   
            Console.Clear();
            System.Console.WriteLine("Player 1,");
            Character player1 = CharacterSelection.ChooseCharacter();
            Console.Clear();
            System.Console.WriteLine("Player 2,");
            Character player2 = CharacterSelection.ChooseCharacter();
            Console.Clear();
            ShowCharacterStats(player1, player2);
            System.Console.WriteLine("");
            System.Console.WriteLine("Player One, enter your name as a string (ex: Pintel)");
            player1.PlayersName = Console.ReadLine();
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Player Two, enter your name as a string (ex: Ragetti)");
            player2.PlayersName = Console.ReadLine();
            System.Console.WriteLine(" ");
            System.Console.WriteLine("------------------------------------------------------------------\n");
            Console.WriteLine("The spirit of Poseidon will decide who attacks first.\n");
            int determineTurn = RandomUtility.WhoGoesFirst();
            System.Console.WriteLine("Player " + determineTurn + " will begin this battle!\n");
            System.Console.WriteLine("Press any key to begin the fight, matey!");
            Console.ReadKey();
            Console.Clear();
            while(player1.Health > 0 && player2.Health > 0)
            {
                if(determineTurn == 1 && (player1.Health > 0 && player2.Health > 0))
                {
                    Console.Clear();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Player 1's Turn\n");
                    System.Console.WriteLine(player1.PlayersName + ", you are the attacker" + ".\n");
                    if(player1.Name == "Jack Sparrow")
                    {
                        player1.attackBehavior.Attack();
                        DistractOpponent.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player1.Name == "Davy Jones")
                    {
                        player1.attackBehavior.Attack();
                        CannonFire.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player1.Name == "Will Turner")
                    {
                        player1.attackBehavior.Attack();
                        Sword.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player1.Name == "Captain Barbossa")
                    {
                        player1.attackBehavior.Attack();
                        MonkeyOnTheLoose.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player1.Name == "Prison Dog")
                    {
                        player1.attackBehavior.Attack();
                        BiteAndScatch.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player1.Name == "Elizabeth Swann")
                    {
                        player1.attackBehavior.Attack();
                        FlintlockPistol.DamageCalculation(player1, player2, determineTurn);
                    }
                    System.Console.WriteLine("Player 2's Health: " + player2.Health + "\n\n");
                    System.Console.WriteLine("-----------------------------------------------------------\n\n");
                    ShowCharacterStats(player1, player2);
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    determineTurn = 2;
                }
                if(determineTurn == 2 && (player1.Health > 0 && player2.Health > 0))
                {
                    Console.Clear();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Player 2's Turn\n");
                    System.Console.WriteLine(player2.PlayersName + ", you are the attacker" + ".\n");
                    if(player2.Name == "Jack Sparrow")
                    {
                        player2.attackBehavior.Attack();
                        DistractOpponent.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player2.Name == "Davy Jones")
                    {
                        player2.attackBehavior.Attack();
                        CannonFire.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player2.Name == "Will Turner")
                    {
                        player2.attackBehavior.Attack();
                        Sword.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player2.Name == "Captain Barbossa")
                    {
                        player2.attackBehavior.Attack();
                        MonkeyOnTheLoose.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player2.Name == "Prison Dog")
                    {
                        player2.attackBehavior.Attack();
                        BiteAndScatch.DamageCalculation(player1, player2, determineTurn);
                    }
                    if(player2.Name == "Elizabeth Swann")
                    {
                        player2.attackBehavior.Attack();
                        FlintlockPistol.DamageCalculation(player1, player2, determineTurn);
                    }
                    System.Console.WriteLine("Player 1's Health: " + player1.Health + "\n\n");
                    System.Console.WriteLine("-----------------------------------------------------------\n\n");
                    ShowCharacterStats(player1, player2);
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    determineTurn = 1;
                }
                CheckHealth(player1, player2);
            }
        }
        public static void ToStringPl(Character player)
        {
            Console.WriteLine("    Character: " + player.Name + "\n    Max Power: " + player.MaxPower + "\n    Health: " + player.Health +"\n    Attack Strength: " + player.AttackStrength + "\n    Defensive Power: " + player.DefensePower);
        }
        static double CheckHealth(Character player1, Character player2)
        {
            if(player1.Health <= 0)
            {
                Console.Clear();
                System.Console.WriteLine("Player 2 has defeated their opponent! Yo-Ho, " + player2.PlayersName + "! A Pirate's Life for thee...\n");
                System.Console.WriteLine("And for you, " + player1.PlayersName + ", Dead Men Tell No Tales...\n");
                System.Console.WriteLine("Press any key to exit to the main menu.");
                Console.ReadKey();
                Console.Clear();
                return player1.Health;
            }
            else if(player2.Health <= 0)
            {
                Console.Clear();
                System.Console.WriteLine("Player 1 has defeated their opponent! Yo-Ho, " + player1.PlayersName + ". A Pirate's Life for thee...\n");
                System.Console.WriteLine("And for you, " + player2.PlayersName + ", Dead Men Tell No Tales...\n");
                System.Console.WriteLine("Press any key to exit to the main menu.");
                Console.ReadKey();
                Console.Clear();
                return player2.Health;
            }
            return -2.0;
        }
        static void ShowCharacterStats(Character player1, Character player2)
        {
            System.Console.WriteLine("Player 1's Character Stats:\n");
            ToStringPl(player1);
            System.Console.WriteLine("");
            System.Console.WriteLine("Player 2's Character Stats:\n");
            ToStringPl(player2);
        }
    }
}