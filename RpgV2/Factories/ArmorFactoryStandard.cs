using RpgV2.Helpers;
using RpgV2.Interfaces;
using RpgV2.Interfaces.Factories;
using RpgV2.Items.Armor;

using System;

namespace RpgV2.Factories
{
    public class ArmorFactoryStandard : IArmorFactory
    {
        public IArmor CreateArmor()
        {
            int index = RNG.RandomInt(1, 4);

            switch (index)
            {
                case 1:
                    return new ClothGloves("Silk Smooth");
                case 2:
                    return new LeatherBoots("Cow skin leather boots");
                case 3:
                    return new PlateBoots("Polished plate boots");
                case 4:
                    return new WoodenShield("Viking shield");
                default:
                    throw new Exception($"Could not generate armor with index {index} ");
            }
        }
    }
}
