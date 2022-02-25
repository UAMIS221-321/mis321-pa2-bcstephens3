namespace mis321_pa2_bcstephens3.Interphases
{
    public class CannonFire  : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("You are using the cannon fire attack.");
        }
        public static double DamageCalculation(Character player1, Character player2, int determineTurn)
        {
            if(determineTurn == 1) 
            {
                if(player1.AttackStrength < player2.DefensePower)
                {
                    player2.Health = player2.Health -1;
                }
                else
                {
                    if(player2.Name == "Jack Sparrow")
                    {
                        System.Console.WriteLine("Advantage Awarded: Davy Jones beats Jack Sparrow");
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
                if(player2.AttackStrength < player1.DefensePower)
                {
                    player1.Health = player1.Health -1;
                }
                else
                {
                    if(player1.Name == "Jack Sparrow")
                    {
                        System.Console.WriteLine("Advantage Awarded: Davy Jones beats Jack Sparrow");
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