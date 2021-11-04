using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Interfaces.Factories;
using RPG_V2.Items.Armour;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Factories
{
    public class ArmorFactoryStandard : IArmorFactory
    {
        public IArmor CreateArmor()
        {
            int index = RNG.RandomInt(1, 4);

            switch (index)
            {
                case 1:
                    return new ClothGloves();
                case 2:
                    return new LeatherBoots();
                case 3:
                    return new PlateBoots();
                case 4:
                    return new WoodenShield();
                default:
                    throw new Exception($"Could not generate item with index {index}");
            }
        }
    }
}
