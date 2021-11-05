using RpgV2.Helpers;
using RpgV2.Interfaces;
using RpgV2.Interfaces.Factories;
using RpgV2.Items.Weapons;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Factories
{
    class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            int index = RNG.RandomInt(1, 4);

            switch (index)
            {
                case 1:
                    return new IronSword();
                case 2:
                    return new SteelLance();
                case 3:
                    return new WoodenMace();
                default:
                    throw new Exception($"Could not generate Weapon with index {index} ");
            }
        }
    }
}
