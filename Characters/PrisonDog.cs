namespace mis321_pa2_bcstephens3.Interphases
{
    public class PrisonDog : Character
    {
        public PrisonDog()
        {
            Name = "Prison Dog";
            attackBehavior = new BiteAndScatch();
        }
        public new void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
    }
}