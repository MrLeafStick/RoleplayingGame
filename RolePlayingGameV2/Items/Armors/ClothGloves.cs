namespace RolePlayingGameV2.Items.Armors
{
    class ClothGloves : ArmorBase
    {
        public override string Description 
        {
            get { return "Black cloth gloves"; }
        }

        public override int MaxArmorPoints { get { return 10; } }

        public override string Name { get; }
    }   
}