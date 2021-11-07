namespace RPG_V3.Interfaces
{
    public interface IWeapon : IItem
    {
        public double MaxDamagePoints { get; }
        public double MinDamagePoints { get; }
    }
}
