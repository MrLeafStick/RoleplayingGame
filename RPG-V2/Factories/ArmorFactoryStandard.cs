using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Interfaces.Factories;
using RPG_V2.Items.Armour;
using System;

namespace RPG_V2.Factories
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
                _ => throw new Exception($"Could not generate item with index {index}"),
            };
        }
    }
}
