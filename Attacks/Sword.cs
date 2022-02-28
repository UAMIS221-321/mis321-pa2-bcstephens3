namespace mis321_pa2_bcstephens3.Interphases
{
    public class Sword : IAttack
    {
        public void Attack() //EXTRA: underdog advantage calculation
        {
            System.Console.WriteLine("You are using the sword attack.");
        }
        public static double DamageCalculation(Character player1, Character player2, int determineTurn)
        {
            if(determineTurn == 1) 
            {
                if(player1.AttackStrength <= player2.DefensePower)
                {
                    if(player2.Name == "Davy Jones") //EXTRA: underdog advantage calculation
                    {
                        System.Console.WriteLine("Advantage Awarded: Will Turner beats Davy Jones");
                        int advBoost = RandomUtility.AdvantageHelper();
                        player2.Health = player2.Health - (1 * advBoost);
                    }
                    else
                    {
                        player2.Health = player2.Health - 1;
                    }
                }
                else
                {
                    if(player2.Name == "Davy Jones")
                    {
                        System.Console.WriteLine("Advantage Awarded: Will Turner beats Davy Jones");
                        player2.Health = player2.Health - ((player1.AttackStrength - player2.DefensePower) * 1.2);
                    }
                    else
                    {
                        player2.Health = player2.Health - ((player1.AttackStrength - player2.DefensePower) * 1);
                    }
                }
                return player2.Health;
            }
            else if(determineTurn == 2)
            {
                if(player2.AttackStrength <= player1.DefensePower)
                {
                    if(player1.Name == "Davy Jones")
                    {
                        System.Console.WriteLine("Advantage Awarded: Will Turner beats Davy Jones");
                        int advBoost = RandomUtility.AdvantageHelper();
                        player1.Health = player1.Health - (1 * advBoost);
                    }
                    else
                    {
                        player1.Health = player1.Health - 1;
                    }
                }
                else
                {
                    if(player1.Name == "Davy Jones")
                    {
                        System.Console.WriteLine("Advantage Awarded: Will Turner beats Davy Jones");
                        player1.Health = player1.Health - ((player2.AttackStrength - player1.DefensePower) * 1.2);
                    }
                    else
                    {
                        player1.Health = player1.Health - ((player2.AttackStrength - player1.DefensePower) * 1); 
                    }
                }
                return player1.Health;
            }
            return -2;
        }
    }
}