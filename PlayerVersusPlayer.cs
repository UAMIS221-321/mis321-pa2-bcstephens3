using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class PlayerVersusPlayer
    {
        public static void Gameplay()
        {   
            //the current stuff
            
            Console.Clear();
            Character player1 = CharacterSelection.ChooseCharacter();
            Character player2 = CharacterSelection.ChooseCharacter();
            ToStringPl(player1);
            System.Console.WriteLine("");
            ToStringPl(player2);
            System.Console.WriteLine("");
            System.Console.WriteLine("Player One, enter your name as a string (ex: Dan)");
            player1.PlayersName = Console.ReadLine();
            System.Console.WriteLine("Player Two, enter your name as a string (ex: Dan)");
            player2.PlayersName = Console.ReadLine();
            Console.WriteLine("The game will decide who goes first.");
            int determineTurn = RandomUtility.WhoGoesFirst();
            System.Console.WriteLine(determineTurn);
            while(player1.Health > 0 && player2.Health > 0)
            {
                if(determineTurn == 1 && (player1.Health > 0 && player2.Health > 0))
                {
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Player 1's Turn");
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("You are attacking, "+ player1.PlayersName);
                    System.Console.WriteLine("");
                    // player2.Health = player2.Health - 20;
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
                    System.Console.WriteLine("Player 2's Health: " + player2.Health);
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Press any key continue.");
                    Console.ReadKey();

                    determineTurn = 2;
                }
                if(determineTurn == 2 && (player1.Health > 0 && player2.Health > 0))
                {
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Player 2's Turn");
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("You are attacking, "+ player2.PlayersName);
                    System.Console.WriteLine("");
                    // player1.Health = player1.Health - 20;
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
                    //player1.DamageCalculation(player1, player2, determineTurn);
                    System.Console.WriteLine("Player 1's Health: " + player1.Health);
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Press any key continue.");
                    Console.ReadKey();
                    //CheckHealth(player1, player2);
                    determineTurn = 1;
                }
                CheckHealth(player1, player2);
            }
            //CheckHealth(player1, player2);
            
            //the dated stuff 
            
                // Console.Clear();
                // Character player1 = new Character();
                // CharacterSelection.ChooseP1(ref player1);
                // Character player2 = new Character();
                // CharacterSelection.ChooseP2(ref player2);
                // ToStringP1(ref player1);
                // System.Console.WriteLine("");
                // ToStringP2(ref player2);
                // System.Console.WriteLine("");
                // System.Console.WriteLine("The game will decide who goes first.");
                // int determineTurn = RandomUtility.WhoGoesFirst();
                // System.Console.WriteLine(determineTurn);
            
            //old stuff

                // Character player1Character = new Character();
                // Character player2Character = new Character();
                //System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
                // Character player1Character = new JackSparrow();
                // CharacterSelection(player1Character);
                // System.Console.WriteLine(player1Character.Name);
        }

        //the working tostrings
        
        public static void ToStringPl(Character player)
        {
            Console.WriteLine("Character: " + player.Name + "\nMax Power: " + player.MaxPower + "\nHealth: " + player.Health +"\nAttack Strength: " + player.AttackStrength + "\nDefensive Power: " + player.DefensePower);
        }

        static double CheckHealth(Character player1, Character player2)
        {
            if(player1.Health <= 0)
            {
                System.Console.WriteLine("Player 2 Wins!! Congrats, " + player2.PlayersName);
                return player1.Health;
            }
            else if(player2.Health <= 0)
            {
                System.Console.WriteLine("Player 1 Wins!! Congrats, " + player1.PlayersName);
                return player2.Health;
            }
            return -2.0;
        }
        //random
        
            // CharacterSelection(player1Choice);
            // System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            // string player2Choice = Console.ReadLine();
            //CharacterSelection(player2Choice);
            // Character player1 = new JackSparrow();

            // System.Console.WriteLine("");
            
            // System.Console.WriteLine(player1.Name);
            // System.Console.WriteLine(player1.MaxPower);
            // System.Console.WriteLine(player1.Health);
            // System.Console.WriteLine(player1.AttackStrength);
            // System.Console.WriteLine(player1.DefensePower);

            // System.Console.WriteLine("");

            // Character player2 = new WillTurner();
            // System.Console.WriteLine(player2.Name);
            // System.Console.WriteLine(player2.MaxPower);
            // System.Console.WriteLine(player2.Health);
            // System.Console.WriteLine(player2.AttackStrength);
            // System.Console.WriteLine(player2.DefensePower);

            // System.Console.WriteLine("");

        //the original while one we made

            // public static Character CharacterSelection(Character player1Character)
            // {
            //     System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            //     string p1CharMenuChoice = Console.ReadLine();
            //     while(p1CharMenuChoice != "455")
            //     {
            //         if(p1CharMenuChoice == "1")
            //         {
            //             player1Character = new JackSparrow();
            //             p1CharMenuChoice = "455";
            //         }
            //         else if(p1CharMenuChoice == "2")
            //         {
            //             player1Character = new WillTurner();
            //             p1CharMenuChoice = "455";
            //         }
            //         else if(p1CharMenuChoice == "3")
            //         {
            //             player1Character = new DavyJones();
            //             p1CharMenuChoice = "455";
            //         }
            //         else if(p1CharMenuChoice != "1" && p1CharMenuChoice != "2" && p1CharMenuChoice != "3")
            //         {
            //             System.Console.WriteLine("Not a valid character, matey. Try again.");
            //             System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            //             p1CharMenuChoice = Console.ReadLine();
            //         }   
            //     }
            //     return player1Character;
            // }

        //the switch
        
            // public static void CharacterSelection(string playerChoice)
            // {
            //     switch (playerChoice) 
            //     {
            //         case "1":
            //         JackSparrrowMaker();
            //         break;
            //         case "2":
            //         WillTurnerMaker();
            //         break;
            //         case "3":
            //          DavyJonesMaker();
            //         break;
            //         default:
            //         Console.WriteLine("Invalid input");
            //         break;
            //     }
            // }

        //the chacracter creation methods: early on
        
            // public static JackSparrow JackSparrrowMaker()
            // {
            //     JackSparrow p1CharMenuChoice = new JackSparrow();
            //     return p1CharMenuChoice;
            // }
            // public static WillTurner WillTurnerMaker()
            // {
            //     WillTurner p1CharMenuChoice = new WillTurner();
            //     return p1CharMenuChoice;
            // }
            // public static DavyJones DavyJonesMaker()
            // {
            //     DavyJones p1CharMenuChoice = new DavyJones();
            //     return p1CharMenuChoice;
            // }
    }
}