using RpgV2.Helpers;
using RpgV2.Interfaces.Factories;
using RpgV2.Items.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Factories
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
                _ => throw new Exception($"Could not generate item with index {index} "),
            };
        }
    }
}
