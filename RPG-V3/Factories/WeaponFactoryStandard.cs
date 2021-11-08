using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;
using RPG_V3.Items;

namespace RPG_V3.Factories
{
    class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            return new Weapon(
                Randomizer.GetRandom(WeaponCategory.List()),
                Randomizer.GetRandom(Material.List()),
                100,
                10,
                1000);
            
            //return new Weapon(Randomizer.GetRandom(Weapon.List()));
        }
    }
}
