using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Interfaces.Factories;
using RoleplayingGameV2.Items.Weapons;
using System;

namespace RoleplayingGameV2.Factories
{
    public class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            int index = RNG.RandomInt(1, 4);
            switch (index)
            {
                case 1: return new IronSword();
                case 2: return new SteelLance();
                case 3: return new WoodenMace();
                case 4: return new WoodenStick();
                default: throw new Exception($"Could not generate weapon with index {index}");
            }
        }
    }
}
