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
            int index = RNG.RandomInt(1, 3);

            return index switch
            {
                1 => new IronSword("Sharpened sword", 80, 130),
                2 => new SteelLance("Long stick", 40, 120),
                3 => new WoodenMace("Broken Club", 10, 80),
                _ => throw new Exception($"Could not generate Weapon with index {index} "),
            };
        }
    }
}
