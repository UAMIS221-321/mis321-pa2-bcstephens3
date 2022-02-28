using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class CharacterSelection
    {
        public static Character ChooseCharacter()
        {
            System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones \n4. Captain Barbossa \n5. Prison Dog \n6. Elizabeth Swann");
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
            if(plCharChoice == "Captain Barbossa")
            {
                return new CaptainBarbossa();
            }
            if(plCharChoice == "Prison Dog")
            {
                return new PrisonDog();
            }
            if(plCharChoice == "Elizabeth Swann")
            {
                return new ElizabethSwann();
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
                else if(plCharMenuChoice == "4")
                {
                    plCharChoice = "Captain Barbossa";
                    plBool = true;
                }
                else if(plCharMenuChoice == "5")
                {
                    plCharChoice = "Prison Dog";
                    plBool = true;
                }
                else if(plCharMenuChoice == "6")
                {
                    plCharChoice = "Elizabeth Swann";
                    plBool = true;
                }
                else
                {
                    System.Console.WriteLine("Not a valid character, matey. Try again.");
                    System.Console.WriteLine("Select one of the following characters: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones \n4. Captain Barbossa \n5. Prison Dog \n6. Elizabeth Swann");
                    plCharMenuChoice = Console.ReadLine();
                }   
            }
            return plCharChoice;
        }
    }
}

