namespace RPG_V2.Items.Weapons
{
    public class SteelLance : WeaponBase
    {
        public SteelLance() : base()
        {

        }

        public override string Description
        {
            get { return "Sharpened steel lance"; }
        }

        public override int TotalMaxWeaponDamage { get; }
        public override string Name { get; }
    }
}
