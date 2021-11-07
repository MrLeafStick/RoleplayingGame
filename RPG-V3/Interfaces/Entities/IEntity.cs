using RPG_V3.Entities;
using System.Collections.Generic;

// Base interface for all animate entities, including living creatures,
// animals, humanoids, the undead, monsters, and magical creatures.
namespace RPG_V3.Interfaces
{
    public interface IEntity
    {
        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; }
        public string Name { get; }
        public int GoldOwned { get; set; }
        public double HealthPoints { get; }
        public bool IsDestroyed { get; }

        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }

        public double DealDamage();
        public void ReceiveDamage(double damagePoints);
    }
}
