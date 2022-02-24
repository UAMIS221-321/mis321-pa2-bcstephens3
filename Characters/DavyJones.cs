namespace mis321_pa2_bcstephens3.Interphases
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            Name = "Davy Jones";
            attackBehavior = new CannonFire();
        }
        public new void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
    }
}