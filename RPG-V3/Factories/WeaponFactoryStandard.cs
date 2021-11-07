using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;
using RPG_V3.Interfaces.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_V3.Factories
{
    class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            Weapon weapon = GetRandom(Weapon.List(), RNG._generator);
            //Weapon weapon = new Weapon(GetRandom(Weapon.List(), RNG._generator));

            return weapon;
        }

        T GetRandom<T>(List<T> list, Random random)
        {
            return list.ElementAt(random.Next(0, list.Count));
        }
    }
}
