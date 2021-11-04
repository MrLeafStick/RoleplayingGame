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

            switch (index)
            {
                case 1:
                    return new IronSword();
                case 2:
                    return new SteelLance();
                case 3:
                    return new WoodMace();
                default:
                    throw new Exception($"Could not generate item with index {index}");
            }
        }
    }
}
