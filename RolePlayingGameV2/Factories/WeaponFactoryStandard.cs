using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;
using RolePlayingGameV2.Interfaces.Factories;
using RolePlayingGameV2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGameV2.Factories
{
    public class WeaponFactoryStandard : IWeaponFactory
    {
        public virtual IWeapon CreateWeapon()
        {
            var index = RNG.RandomInt(1, 3);

            switch (index)
            {
                case 1: return new IronSword(5, 10);
                case 2: return new WoodenMace(3, 8);
                case 3: return new SteelLance(7, 13);
                default:
                    throw new Exception($"Could not generate weapon with index {index}");
            }
        }
    }
}
