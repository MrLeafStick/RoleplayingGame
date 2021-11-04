namespace RolePlayingGameV2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword() : base(40)
        {
        }

        public override string Description
        {
            get { return "One-Handed Iron Sword"; }
        }

        public override int TotalMaxWeaponDamage { get; }

        public override string Name { get; }
    }
}
