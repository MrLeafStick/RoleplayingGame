namespace RPG_V3.Interfaces
{
    public interface IArmor : IItem
    {
        public double MaxDamageReduction { get; }
        public double MinDamageReduction { get; }
        public bool IsBroken { get; }
    }
}
