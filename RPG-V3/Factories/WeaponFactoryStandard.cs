using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;
using RPG_V3.Interfaces.Items.Weapons;

namespace RPG_V3.Factories
{
    class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            return new Weapon(Randomizer.GetRandom(Weapon.List()));
        }
    }
}
