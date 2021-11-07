using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Interfaces.Factories;
using RoleplayingGameV2.Items.Armor;
using System;

namespace RoleplayingGameV2.Factories
{
    public class ArmorFactoryStandard : IArmorFactory
    {
        public IArmor CreateArmor()
        {
            int index = RNG.RandomInt(1, 4);
            return index switch
            {
                1 => new ClothGloves(),
                2 => new LeatherBoots(),
                3 => new PlateBoots(),
                4 => new WoodenShield(),
                _ => throw new Exception($"Could not generate armor with index {index}"),
            };
        }
    }
}
