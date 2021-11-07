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
            return index switch
            {
                1 => new IronSword(),
                2 => new SteelLance(),
                3 => new WoodenMace(),
                4 => new WoodenStick(),
                _ => throw new Exception($"Could not generate weapon with index {index}"),
            };
        }
    }
}
