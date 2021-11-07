// Base interface for all in-animate objects, including physical objects,
// magical potions, weapons, armor etc.
namespace RPG_V3.Interfaces
{
    public interface IItem
    {
        public string Name { get; }
        public double Value { get; }
        public double Weight { get; }
    }
}
