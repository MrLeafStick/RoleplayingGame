using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Interfaces.Factories;
using RPG_V2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Factories
{
    class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            int index = RNG.RandomInt(1, 3);

            return index switch
            {
                1 => new IronSword(),
                2 => new SteelLance(),
                3 => new WoodMace(),
                _ => throw new Exception($"Could not generate item with index {index}"),
            };
        }
    }
}
