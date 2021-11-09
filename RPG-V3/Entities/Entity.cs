using RPG_V3.Helpers;
using RPG_V3.Interfaces;

namespace RPG_V3.Entities
{
    public class Entity : IEntity
    {
        public Entity(string name, EntityCategory category, EntitySpecies species) //TODO: add healthPoints
        {
            Name = name;
            Category = category;
            Species = species;

            HealthPoints = SetInitialHealthPoints();
        }

        public Entity(Entity entity)
        {
            Category = entity.Category;
            Species = entity.Species;
            Name = entity.Name;
            HealthPoints = entity.HealthPoints;
        }

        public EntityCategory Category { get; set; }
        public EntitySpecies Species { get; set; }
        public string Name { get; set; }
        public double HealthPoints { get; set; }
        public bool IsDestroyed { get { return HealthPoints <= 0; } }

        public double SetInitialHealthPoints()
        {
            return Randomizer.RandomDouble(1.0, Species.MaxHealthPoints);
        }

        public virtual double DealDamage()
        {
            return 0.0;
        }

        public virtual void ReceiveDamage(double damagePoints)
        {
            HealthPoints -= damagePoints;
        }

        public override string ToString()
        {
            var entityString = $"{Name} the {(Category.Name == "Living" ? "\b" : Category.Name)}{(Category.Name == "Were" ? "-" : " ")}.\n";

            return entityString;
        }
    }
}