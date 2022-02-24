using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class CharacterSelection
    {
        public static Character ChooseCharacter()
        {
            System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            string plCharMenuChoice = Console.ReadLine();
            string plCharChoice = "";
            bool plBool = false;
            playerCharacterSelect(plCharMenuChoice, ref plCharChoice, plBool);
            if(plCharChoice == "Jack Sparrow")
            {
                return new JackSparrow();
            }
            if(plCharChoice == "Will Turner")
            {
                return new WillTurner();
            }
            if(plCharChoice == "Davy Jones")
            {
                return new DavyJones();
            }
            else
            {
                return new Character();
            }
        }

        public static string playerCharacterSelect(string plCharMenuChoice, ref string plCharChoice, bool plBool)
        {
            while(plBool == false)
            {
                if(plCharMenuChoice == "1")
                {
                    plCharChoice = "Jack Sparrow";
                    plBool = true;
                }
                else if(plCharMenuChoice == "2")
                {
                    plCharChoice = "Will Turner";
                    plBool = true;
                }
                else if(plCharMenuChoice == "3")
                {
                    plCharChoice = "Davy Jones";
                    plBool = true;
                }
                else
                {
                    System.Console.WriteLine("Not a valid character, matey. Try again.");
                    System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
                    plCharMenuChoice = Console.ReadLine();
                }   
            }
            return plCharChoice;
        }
        // public static void ChooseP1(ref Character player1)
        // {
        //     System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
        //     string plCharMenuChoice = Console.ReadLine();
        //     string plCharChoice = "";
        //     bool plBool = false;
        //     p1CharacterSelect(plCharMenuChoice, ref plCharChoice, plBool);
            
        //     if(plCharChoice == "Jack Sparrow")
        //     {
        //         player1 = new JackSparrow();
        //     }
        //     if(plCharChoice == "Will Turner")
        //     {
        //         player1 = new WillTurner();
        //     }
        //     if(plCharChoice == "Davy Jones")
        //     {
        //         player1 = new DavyJones();
        //     }
        // }
        // public static string p1CharacterSelect(string plCharMenuChoice, ref string plCharChoice, bool plBool)
        // {
        //     while(plBool == false)
        //     {
        //         if(plCharMenuChoice == "1")
        //         {
        //             plCharChoice = "Jack Sparrow";
        //             plBool = true;
        //         }
        //         else if(plCharMenuChoice == "2")
        //         {
        //             plCharChoice = "Will Turner";
        //             plBool = true;
        //         }
        //         else if(plCharMenuChoice == "3")
        //         {
        //             plCharChoice = "Davy Jones";
        //             plBool = true;
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("Not a valid character, matey. Try again.");
        //             System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
        //             plCharMenuChoice = Console.ReadLine();
        //         }   
        //     }
        //     return plCharChoice;
        // }

        

        // public static void ChooseP2(ref Character player2)
        // {
        //     System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
        //     string p2CharMenuChoice = Console.ReadLine();
        //     string p2CharChoice = "";
        //     bool p2bool = false;
        //     p1CharacterSelect(p2CharMenuChoice, ref p2CharChoice, p2bool);
            
        //     if(p2CharChoice == "Jack Sparrow")
        //     {
        //         player2 = new JackSparrow();
        //     }
        //     if(p2CharChoice == "Will Turner")
        //     {
        //         player2 = new WillTurner();
        //     }
        //     if(p2CharChoice == "Davy Jones")
        //     {
        //         player2 = new DavyJones();
        //     }
        // }
        // public static string p2CharacterSelect(string p2CharMenuChoice, ref string p2CharChoice, bool p2bool)
        // {
        //     while(p2bool == false)
        //     {
        //         if(p2CharMenuChoice == "1")
        //         {
        //             p2CharChoice = "Jack Sparrow";
        //             p2bool = true;
        //         }
        //         else if(p2CharMenuChoice == "2")
        //         {
        //             p2CharChoice = "Will Turner";
        //             p2bool = true;
        //         }
        //         else if(p2CharMenuChoice == "3")
        //         {
        //             p2CharChoice = "Davy Jones";
        //             p2bool = true;
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("Not a valid character, matey. Try again.");
        //             System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
        //             p2CharMenuChoice = Console.ReadLine();
        //         }   
        //     }
        //     return p2CharChoice;
        // }
    }
}

