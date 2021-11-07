namespace RoleplayingGameV2.Items.Weapons
{
    public class WoodenMace : WeaponBase
    {
        public WoodenMace()
        {
        }

        public override int TotalMaxWeaponDamage { get { return 30; } }
        public override int TotalMinWeaponDamage { get { return 10; } }

        public override string Name { get { return "Rough Wooden Mace"; } }
    }
}
