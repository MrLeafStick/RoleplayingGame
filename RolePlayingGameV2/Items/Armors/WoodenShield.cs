namespace RolePlayingGameV2.Items.Armors
{
    public class WoodenShield : ArmorBase
    {
        public override string Description { get { return "Round wooden shield"; } }

        public override int MaxArmorPoints { get { return 40; } }

        public override string Name { get; }
    }
}