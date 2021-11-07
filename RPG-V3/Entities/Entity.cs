using RPG_V3.GameManagement;
using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RPG_V3.Entities
{
    public class Entity : IEntity
    {
        public Entity(string name, EntityCategory category, EntitySpecies species, EntityOccupation occupation)
        {
            Name = name;
            Category = category;
            Species = species;
            Occupation = occupation;

            HealthPoints = SetInitialHealthPoints();
            GoldOwned = SetInitialGoldOwned();
            ArmorOwned = SetInitialArmorOwned();
            WeaponsOwned = SetInitialWeaponsOwned();
        }

        public Entity(Entity entity)
        {
            Category = entity.Category;
            Species = entity.Species;
            Occupation = entity.Occupation;

            Name = entity.Name;
            GoldOwned = entity.GoldOwned;
            HealthPoints = entity.HealthPoints;

            ArmorOwned = entity.ArmorOwned;
            WeaponsOwned = entity.WeaponsOwned;
        }

        public EntityCategory Category { get; }
        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; }
        public string Name { get; }
        public int GoldOwned { get; set; }
        public double HealthPoints { get; private set; }
        public bool IsDestroyed { get { return HealthPoints <= 0; } }

        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }

        private List<IWeapon> SetInitialWeaponsOwned()
        {
            var initalWeapons = new List<IWeapon>();
            for (int i = 0; i < Randomizer.RandomInt(1, 5); i++) // TODO: initialWeapons cannot be 0;
            {
                initalWeapons.Add(GameFactory.Instance().WeaponFactory.CreateWeapon());
            }
            return initalWeapons;
        }

        protected List<IArmor> SetInitialArmorOwned()
        {
            var initalArmor = new List<IArmor>();
            for (int i = 0; i < Randomizer.RandomInt(0, 5); i++)
            {
                initalArmor.Add(GameFactory.Instance().ArmorFactory.CreateArmor());
            }
            return initalArmor;
        }

        protected double SetInitialHealthPoints()
        {
            return Randomizer.RandomDouble(1.0, Species.MaxHealthPoints);
        }

        protected int SetInitialGoldOwned()
        {
            return Randomizer.RandomInt(0, 1000);
        }

        public virtual double DealDamage()
        {
            return WeaponsOwned.Count > 0 ? WeaponsOwned.Select(weapon => weapon.MaxDamagePoints).Max() : 0.0;
        }

        public void ReceiveDamage(double damagePoints)
        {
            HealthPoints -= damagePoints;
        }

        public void AddArmor(IArmor armor)
        {
            ArmorOwned.Add(armor);
        }

        public void AddWeapons(IWeapon weapon)
        {
            WeaponsOwned.Add(weapon);
        }

        public void ClearItems()
        {
            ArmorOwned.Clear();
            WeaponsOwned.Clear();
        }

        public override string ToString()
        {
            var entityString = $"{Name} the {(Category.Name == "Living" ? "\b" : Category.Name)}{(Category.Name == "Were" ? "-" : " ")}{Species.Name} is {Occupation.Name}.\n";

            var weaponString = $"{Name} has the following weapons:\n";

            foreach (var weapon in WeaponsOwned)
            {
                weaponString += $" {weapon.Name}\n";
            }

            var armorString = $"{Name} has the following armor:\n";

            foreach (var armor in ArmorOwned)
            {
                armorString += $" {armor.Name}\n";
            }

            return entityString + weaponString + armorString;
        }
    }
}