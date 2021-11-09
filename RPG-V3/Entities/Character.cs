using RPG_V3.GameManagement;
using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using System.Collections.Generic;

namespace RPG_V3.Entities
{
    public class Character : Entity, ICharacter
    {
        public Character(string name, EntityCategory category, EntitySpecies species, EntityOccupation occupation) 
            : base(name, category, species)
        {
            Occupation = occupation;

            HealthPoints = SetInitialHealthPoints();
            GoldOwned = SetInitialGoldOwned();
            ArmorOwned = SetInitialArmorOwned();
            WeaponsOwned = SetInitialWeaponsOwned();
        }

        public Character(Character entity) : base(entity)
        {
            Occupation = entity.Occupation;
            GoldOwned = entity.GoldOwned;
            ArmorOwned = entity.ArmorOwned;
            WeaponsOwned = entity.WeaponsOwned;
        }

        public EntityOccupation Occupation { get; }
        public int GoldOwned { get; set; }
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

        protected int SetInitialGoldOwned()
        {
            return Randomizer.RandomInt(0, 1000);
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
