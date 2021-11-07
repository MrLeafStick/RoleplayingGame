namespace RolePlayingGameV2.Items.Weapons
{
    class WoodenMace : WeaponBase
    {
        public WoodenMace(int minDamage, int maxDamage) : base(minDamage,maxDamage){}
        public override string Description { get { return "Rough wooden mace"; } }
        public override string Name { get; }
    }
}
