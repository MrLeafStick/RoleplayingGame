using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;
using RolePlayingGameV2.Interfaces.Factories;
using RolePlayingGameV2.Items.Armors;
using System;

namespace RolePlayingGameV2.Factories
{
    public class ArmorFactoryStandard : IArmorFactory
    {
        public virtual IArmor CreateArmor()
        {
            var index = RNG.RandomInt(1, 7);

            switch (index)
            {
                case 1: return new ClothGloves();
                case 2: return new LeatherBoots();
                case 3: return new PlateBoots();
                case 4: return new WoodenShield();
                default:
                    throw new Exception($"Could not generate armor with index {index}");
            }

            return null; //TODO add weapons..
        }
    }
}
