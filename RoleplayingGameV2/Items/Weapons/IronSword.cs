namespace RoleplayingGameV2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword()
        {
        }

        public override int TotalMaxWeaponDamage { get { return 40; } }
        public override int TotalMinWeaponDamage { get { return 10; } }

        public override string Name { get { return "One-Handed Iron Sword"; } }
    }
}
