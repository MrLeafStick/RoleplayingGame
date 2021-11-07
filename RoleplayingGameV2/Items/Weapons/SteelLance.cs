namespace RoleplayingGameV2.Items.Weapons
{
    public class SteelLance : WeaponBase
    {
        public SteelLance()
        {
        }

        public override int TotalMaxWeaponDamage { get { return 75; } }
        public override int TotalMinWeaponDamage { get { return 10; } }

        public override string Name { get { return "Sharpned Steel Lance"; } }
    }
}
