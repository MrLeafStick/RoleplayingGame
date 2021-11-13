namespace RPG_V3.Interfaces.Items
{
    public interface IMaterial
    {
        public string Name { get; }
        public double StrengthModifier { get; }
        public double ValueModifier { get; }
        public double WeightModifier { get; }
    }
}
