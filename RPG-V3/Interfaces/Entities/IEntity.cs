using RPG_V3.Entities;

// Base interface for all animate entities, including living creatures,
// animals, humanoids, the undead, monsters, and magical creatures.
namespace RPG_V3.Interfaces
{
    public interface IEntity
    {
        public EntitySpecies Species { get; }
        public EntityCategory Category { get; }

        public string Name { get; }
        public double HealthPoints { get; }
        public bool IsDestroyed { get; }

        public double DealDamage();
        public void ReceiveDamage(double damagePoints);
    }
}
