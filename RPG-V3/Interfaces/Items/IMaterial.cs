namespace RPG_V3.Interfaces.Items
{
    public interface IMaterial
    {
        public string Name { get; }
        public string StrengthModifier { get; }
        public string ValueModifier { get; }
        public string WeightModifier { get; }
    }
}
