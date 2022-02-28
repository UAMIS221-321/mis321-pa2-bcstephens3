namespace mis321_pa2_bcstephens3.Interphases
{
    public class CaptainBarbossa : Character
    {
        public CaptainBarbossa() //EXTRA Character
        {
            Name = "Captain Barbossa";
            attackBehavior = new MonkeyOnTheLoose();
        }
        public new void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
    }
}