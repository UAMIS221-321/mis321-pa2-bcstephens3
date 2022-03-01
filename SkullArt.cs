using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class SkullArt
    {
        public static void TheRedCoolSkullArt() //extra: game art/color
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("   _                   _");
            System.Console.WriteLine(" _( )                 ( )_");
            System.Console.WriteLine("(_, |     __ __       | ,_)");
            System.Console.WriteLine(@"  \'\    /  ^  \    /'/");
            System.Console.WriteLine(@"   '\'\,/\      \,/'/'");
            System.Console.WriteLine(@"     '\| []   [] |/'");
            System.Console.WriteLine(@"       (_  /^\  _)");
            System.Console.WriteLine(@"         \  ~  /");
            System.Console.WriteLine(@"         /HHHHH\");
            System.Console.WriteLine(@"       /'/{^^^}\'\");
            System.Console.WriteLine(@"   _,/'/'  ^^^  '\'\,_");
            System.Console.WriteLine(@"  (_, |           | ,_)");
            System.Console.WriteLine(@"    (_)           (_)");
            System.Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void TheGreenCoolSkullArt()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("   _                   _");
            System.Console.WriteLine(" _( )                 ( )_");
            System.Console.WriteLine("(_, |     __ __       | ,_)");
            System.Console.WriteLine(@"  \'\    /  ^  \    /'/");
            System.Console.WriteLine(@"   '\'\,/\      \,/'/'");
            System.Console.WriteLine(@"     '\| []   [] |/'");
            System.Console.WriteLine(@"       (_  /^\  _)");
            System.Console.WriteLine(@"         \  ~  /");
            System.Console.WriteLine(@"         /HHHHH\");
            System.Console.WriteLine(@"       /'/{^^^}\'\");
            System.Console.WriteLine(@"   _,/'/'  ^^^  '\'\,_");
            System.Console.WriteLine(@"  (_, |           | ,_)");
            System.Console.WriteLine(@"    (_)           (_)");
            System.Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void TheGreenShip()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine(@"               |    |    |                 ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine(@"              )_)  )_)  )_)              ");
            System.Console.WriteLine(@"             )___))___))___)            ");
            System.Console.WriteLine(@"            )____)____)_____)");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine(@"          _____|____|____|______");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(@" ---------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.Write(@"\____________________/");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(@"---------");
            System.Console.WriteLine("");
            System.Console.WriteLine(@"   ^^^^^   ^^  ^^^   ^^^^^^^^^^      ^^");
            System.Console.WriteLine(@"     ^^^^      ^^^  ^     ^^^    ^^");
            System.Console.WriteLine(@"          ^^^^      ^^^");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}