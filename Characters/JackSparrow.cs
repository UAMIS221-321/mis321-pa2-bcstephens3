namespace mis321_pa2_bcstephens3.Interphases
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            Name = "Jack Sparrow";
            attackBehavior = new DistractOpponent();
        }
        public new void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
    }
}