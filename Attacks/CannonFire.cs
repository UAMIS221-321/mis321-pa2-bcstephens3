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
            if(determineTurn == 1) //if player1attachstrength > pl2defensepower
            {
                player2.Health = player2.Health - ((player1.AttackStrength - player2.DefensePower) * 1);
                if(player2.Health > 100)
                {
                    player2.Health = 100;
                }
                return player2.Health;
            }
            else if(determineTurn == 2)
            {
                player1.Health = player1.Health - ((player2.AttackStrength - player1.DefensePower) * 1);
                if(player1.Health > 100)
                {
                    player1.Health = 100;
                }
                return player1.Health;
            }
            return -2;
        }
    }
}