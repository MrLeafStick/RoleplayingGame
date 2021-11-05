namespace RolePlayingGameV2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword(int minDamage, int maxDamage) : base(minDamage, maxDamage)
        {
        }

        public override string Description{ get { return "One-Handed Iron Sword"; } }

        public override string Name { get; }
    }
}
