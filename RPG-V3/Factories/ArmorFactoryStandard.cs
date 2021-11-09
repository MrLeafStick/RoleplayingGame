using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;
using RPG_V3.Items;

namespace RPG_V3.Factories
{
    public class ArmorFactoryStandard : IArmorFactory
    {
        public IArmor CreateArmor()
        {
            return new Armor(
                Randomizer.GetRandom(ArmorCategory.List()),
                Randomizer.GetRandom(Material.List()),
                10.0,
                1.0,
                1000.0,
                100.0
                );

            // TODO: randomize values.

            //return new Armor(Randomizer.GetRandom(Armor.List()));
        }
    }
}
