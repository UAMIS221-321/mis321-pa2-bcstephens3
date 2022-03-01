using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class CharacterBios
    {
        public static void CharacterBiosMenu() //extra: character bios
        {
            
            Console.Clear();
            System.Console.WriteLine("Use one of the following integers to learn about each character: \n1. Jack Sparrow\n2. Will Turner\n3. Davy Jones\n4. Captain Barbossa\n5. Prison Dog\n6. Elizabeth Swann\n7. Exit");
            string biosInput = Console.ReadLine();
            while(biosInput != "7")
            {
                if(biosInput != "1" && biosInput != "2" && biosInput != "3" && biosInput != "4" && biosInput != "5" && biosInput != "6")
                {
                    Console.Clear();
                    System.Console.WriteLine("That's not a choice, matey.");
                }
                if(biosInput == "1")
                {
                    Console.Clear();
                    System.Console.WriteLine("Jack Sparrow was a legendary pirate of the Seven Seas, and the irreverent trickster of the Caribbean. A captain of equally dubious morality and sobriety, a master");
                    System.Console.WriteLine("of self-promotion and self-interest, Jack fought a constant and losing battle with his own best tendencies.");
                    System.Console.WriteLine("\nMain Attack: Distract Opponent\n\nAdvantage: Jack Sparrow has an advantage over Will Turner\n\n");
                    //SkullArt.TheGreenCoolSkullArt();
                }
                if(biosInput == "2")
                {
                    Console.Clear();
                    System.Console.WriteLine("Will Turner was an accomplished blacksmith by trade, an excellent swordsman by pursuit and a budding pirate by fate. After embarking on several adventures with"); 
                    System.Console.WriteLine("Captain Jack Sparrow, Will embraced his pirate heritage as he pursued his own purposes.");
                    System.Console.WriteLine("\nMain Attack: Sword\n\nAdvantage: Will Turner has an advantage over Davy Jones\n\n");
                    
                }
                if(biosInput == "3")
                {
                    Console.Clear();
                    System.Console.WriteLine("Davy Jones was the supernatural ruler of the Seven Seas as the condemned captain of the Flying Dutchman. A fearsome and ruthless captain, striking terror into the bravest of sailors, Jones became the stuff of various myths and "); 
                    System.Console.WriteLine("legends of Pirate Lore, particularly relating to the Dutchman and Davy Jones' Locker.");
                    System.Console.WriteLine("\nMain Attack: Cannon Fire\n\nAdvantage: Davy Jones has an advantage over Jack Sparrow\n\n");
                }
                if(biosInput == "4")
                {
                    Console.Clear();
                    System.Console.WriteLine("Captain Barbossa was a legendary and ferocious pirate of the Caribbean and Pirate Lord of the Caspian Sea. A captain of treacherous morality, a vile pirate returned from the dead, and a master of his own fate, Barbossa was  "); 
                    System.Console.WriteLine("the ultimate survivor.");
                    System.Console.WriteLine("\nMain Attack: Ravenous Pet Monkey\n\nAdvantage: Captain Barbossa has an advantage over Prison Dog\n\n");
                }
                if(biosInput == "5")
                {
                    Console.Clear();
                    System.Console.WriteLine("Prison Dog was a canine owned by Captain Edward Teague. Through unknown circumstances, the dog ended up in Port Royal, where he was employed to hold onto the jailer's keys at the Fort Charles prison in Port Royal. He was highly"); 
                    System.Console.WriteLine("loyal to the jailer, and was not swayed by prisoners' attempts to steal the keys, except for Captain Jack Sparrow who almost succeeded.");
                    System.Console.WriteLine("\nMain Attack: Bite and Scratch\n\nAdvantage: Prison Dog has an advantage over Elizabeth Swann\n\n");
                }
                if(biosInput == "6")
                {
                    Console.Clear();
                    System.Console.WriteLine("Elizabeth Swann was the daughter of Governor Weatherby Swann. With an adventurous spirit and the need to break social boundaries, she had long been fascinated with the freewheeling world of buccaneers to a point of learning a"); 
                    System.Console.WriteLine("song about pirates as a child. Over the years, Elizabeth blossomed into a beautiful young lady, though was never satisfied with the affluent, domestic life she had been born into.");
                    System.Console.WriteLine("\nMain Attack: Flintlock Pistol\n\nAdvantage: Elizabeth Swann has an advantage over Captain Barbossa\n\n");
                }
                System.Console.WriteLine("Use one of the following integers to learn about each character: \n1. Jack Sparrow\n2. Will Turner\n3. Davy Jones\n4. Captain Barbossa\n5. Prison Dog\n6. Elizabeth Swann\n7. Exit");
                biosInput = Console.ReadLine();
            }
        }
    }
}