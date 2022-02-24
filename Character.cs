using System;
using System.IO;
namespace mis321_pa2_bcstephens3.Interphases
{
    public class Character
    {
        public string Name {get; set;}
        public double MaxPower {get; set;}
        public double Health {get; set;}
        public double AttackStrength {get; set;}
        public double DefensePower {get; set;}
        public string PlayersName {get; set;}
        public IAttack attackBehavior {get; set;}
        public IDefend defenseBehavior {get; set;} //could do a new random

        public Character()
        {
            attackBehavior = new Sword();
            defenseBehavior = new Defense();
            Health = 100;
            MaxPower = MaxPowerGenerated();
            AttackStrength = AttackStrengthGenerated(MaxPower);
            DefensePower = DefensivePowerGenerated(MaxPower);
        } 
        public void SetAttackBehavior(IAttack attackBehavior)  
        {
            this.attackBehavior = attackBehavior;
        }
        public void SetDefenseBehavior(IDefend defenseBehavior)  
        {
            this.defenseBehavior = defenseBehavior;
        }
        public double MaxPowerGenerated()
        {
            Random randomNumber = new Random();
            double number = randomNumber.Next(1,101);
            return number;
        }
        public double AttackStrengthGenerated(double MaxPower)
        {
            Random randomNumber = new Random();
            double number = randomNumber.Next(1, Convert.ToInt32(MaxPower));
            return number;
        }
        public double DefensivePowerGenerated(double MaxPower)
        {
            Random randomNumber = new Random();
            double number = randomNumber.Next(1, Convert.ToInt32(MaxPower));
            return number;
        }
        //damage calc to attack
        // public double DamageCalculation(Character player1, Character player2, int determineTurn)
        // {
        //     if(determineTurn == 1) //if player1attachstrength > pl2defensepower
        //     {
        //         player2.Health = player2.Health - ((player1.AttackStrength - player2.DefensePower) * 1);
        //         return player2.Health;
        //     }
        //     else if(determineTurn == 2)
        //     {
        //         player1.Health = player1.Health - ((player2.AttackStrength - player1.DefensePower) * 1);
        //         return player1.Health;
        //     }
        //     return -2;
        // }
    }
}