using System;

namespace mis321_pa2_bcstephens3
{
    public class RandomUtility
    {
        public static int WhoGoesFirst()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,3);
            return number;
        }
        public static int AdvantageHelper()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,21);
            return number;
        }
        
    }
}