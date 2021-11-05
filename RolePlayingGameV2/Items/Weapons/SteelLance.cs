namespace RolePlayingGameV2.Items.Weapons
{
    class SteelLance : WeaponBase
    {
        public SteelLance(int minDamage, int maxDamage) : base(minDamage,maxDamage)
        {
        }

        public override string Description { get { return "Sharpened steel lance"; } }
        public override string Name { get; }
    }
}
