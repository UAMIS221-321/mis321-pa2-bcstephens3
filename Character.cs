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
    }
}