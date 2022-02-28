namespace mis321_pa2_bcstephens3.Interphases
{
    public class ElizabethSwann : Character
    {
        public ElizabethSwann()
        {
            Name = "Elizabeth Swann";
            attackBehavior = new FlintlockPistol();
        }
        public new void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
    }
}