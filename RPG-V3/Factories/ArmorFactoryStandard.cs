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
            return new Armor(Randomizer.GetRandom(Armor.List()));
        }
    }
}
