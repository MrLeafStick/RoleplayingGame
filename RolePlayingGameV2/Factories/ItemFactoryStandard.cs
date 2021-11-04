using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;
using RolePlayingGameV2.Interfaces.Factories;
using RolePlayingGameV2.Items.Armors;
using RolePlayingGameV2.Items.Weapons;
using System;

namespace RolePlayingGameV2.Factories
{
    public class ItemFactoryStandard : IItemFactory
    {
        public virtual IItem CreateItem()
        {
            var index = RNG.RandomInt(1, 7);

            switch (index)
            {
                case 1: return new ClothGloves();
                case 2: return new LeatherBoots();
                case 3: return new PlateBoots();
                case 4: return new WoodenShield();
                case 5: return new IronSword();
                case 6: return new WoodenMace();
                case 7: return new SteelLance();
                default:
                    throw new Exception($"Could not generate item with index {index}");
            }

            return null; //TODO add weapons..
        }
    }
}
