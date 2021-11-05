using RpgV2.Helpers;
using RpgV2.Interfaces.Factories;
using RpgV2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Factories
{
    public class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            int index = RNG.RandomInt(1, 3);
            return index switch
            {
                1 => new IronSword(),
                2 => new SteelLance(),
                3 => new WoodenMace(),
                _ => throw new Exception($"Could not generate item with index {index} "),
            };
        }
    }
}
