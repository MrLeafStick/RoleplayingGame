﻿using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Interfaces.Factories;
using RPG_V2.Items.Weapons;
using System;

namespace RPG_V2.Factories
{
    class WeaponFactoryStandard : IWeaponFactory
    {
        public IWeapon CreateWeapon()
        {
            int index = RNG.RandomInt(1, 4);

            return index switch
            {
                1 => new IronSword(),
                2 => new SteelLance(),
                3 => new WoodMace(),
                4 => new BronzeDagger(),
                _ => throw new Exception($"Could not generate item with index {index}"),
            };
        }
    }
}