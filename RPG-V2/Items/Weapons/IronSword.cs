namespace RPG_V2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword() : base()
        {

        }

        public override string Description
        {
            get { return "One-handed Iron Sword"; }
        }

        public override int TotalMaxWeaponDamage { get; }
        public override string Name { get; }
    }
}
