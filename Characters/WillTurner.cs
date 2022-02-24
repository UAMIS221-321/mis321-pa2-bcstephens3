namespace mis321_pa2_bcstephens3.Interphases
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            Name = "Will Turner";
            attackBehavior = new Sword();
        }
        public new void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
    }
}