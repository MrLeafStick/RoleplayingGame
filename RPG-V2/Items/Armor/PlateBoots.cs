namespace RPG_V2.Items.Armour
{
    class PlateBoots : ArmorBase
    {
        public override string Description
        {
            get { return "Hardened plate boots"; }
        }

        public override int ArmorPoints
        {
            get { return 65; }
        }

        public override int MaxArmorPoints { get; }
        public override string Name { get; }
    }
}
