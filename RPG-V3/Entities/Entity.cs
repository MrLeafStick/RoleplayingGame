using RPG_V3.GameManagement;
using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Items.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_V3.Entities
{
    public class Entity : IEntity
    {
        public Entity(string name, EntityType type, EntitySpecies species, EntityOccupation occupation)
        {
            Name = name;
            Type = type;
            Species = species;
            Occupation = occupation;

            HealthPoints = SetInitialHealthPoints();
            GoldOwned = SetInitialGoldOwned();
            ArmorOwned = SetInitialArmorOwned();
            WeaponsOwned = SetInitialWeaponsOwned();
        }

        public EntityType Type { get; }
        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; }
        public string Name { get; }
        public int GoldOwned { get; set; }
        public double HealthPoints { get; private set; }
        public bool IsDead { get { return HealthPoints <= 0; } }

        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }

        private List<IWeapon> SetInitialWeaponsOwned()
        {
            var initalWeapons = new List<IWeapon>();
            for (int i = 0; i < RNG.RandomInt(1, 5); i++) // TODO: initialWeapons cannot be 0;
            {
                initalWeapons.Add(GameFactory.Instance().WeaponFactory.CreateWeapon());
            }
            return initalWeapons;
        }

        protected virtual List<IArmor> SetInitialArmorOwned()
        {
            var initalArmor = new List<IArmor>();
            for (int i = 0; i < RNG.RandomInt(0, 5); i++)
            {
                initalArmor.Add(GameFactory.Instance().ArmorFactory.CreateArmor());
            }
            return initalArmor;
        }

        protected virtual double SetInitialHealthPoints()
        {
            return RNG.RandomDouble(1.0, Species.MaxHealthPoints);
        }

        protected virtual int SetInitialGoldOwned()
        {
            return RNG.RandomInt(0, 1000);
        }

        public virtual double DealDamage()
        {
            return WeaponsOwned.Count > 0 ? WeaponsOwned.Select(weapon => weapon.MaxDamagePoints).Max() : 0;
        }

        public virtual void ReceiveDamage(double damagePoints)
        {
            HealthPoints -= damagePoints;
        }

        public virtual void AddArmor(IArmor armor)
        {
            ArmorOwned.Add(armor);
        }

        public virtual void AddWeapons(IWeapon weapon)
        {
            WeaponsOwned.Add(weapon);
        }

        public virtual void ClearItems()
        {
            ArmorOwned.Clear();
            WeaponsOwned.Clear();
        }

        public virtual IItem GetInitialItem()
        {
            Armor armor = GetRandom(Armor.List(), RNG._generator);

            return armor;
        }

        public override string ToString()
        {
            var entityString = $"{Name} the {(Type.Name == "Living" ? "\b" : Type.Name)}{(Type.Name == "Were" ? "-" : " ")}{Species.Name} is {Occupation.Name}.\n";

            var weaponString = $"{Name} has the following weapons:\n";

            foreach (var weapon in WeaponsOwned)
            {
                weaponString += $" {weapon.Name}\n";
            }

            var armorString = $"{Name} has the following armor:\n";

            foreach(var armor in ArmorOwned)
            {
                armorString += $" {armor.Name}\n";
            }

            return entityString + weaponString + armorString;
        }

        T GetRandom<T>(List<T> list, Random random)
        {
            return list.ElementAt(random.Next(0, list.Count));
        }
    }


}
