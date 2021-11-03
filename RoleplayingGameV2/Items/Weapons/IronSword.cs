namespace RoleplayingGameV2.Items.Weapons
{
    public class IronSword : WeaponBase
    {
        public IronSword() : base(40.0)
        {
        }

        public override string Description 
        { 
            get { return "One-Handed Iron Sword"; }
        }
    }
}
