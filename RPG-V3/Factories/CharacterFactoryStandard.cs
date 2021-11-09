using RPG_V3.Entities;
using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;

namespace RPG_V3.Factories
{
    public class CharacterFactoryStandard : ICharacterFactory
    {
        public ICharacter CreateCharacter()
        {
            return new Character(
                Randomizer.GenerateName(),
                Randomizer.GetRandom(EntityCategory.List()),
                Randomizer.GetRandom(EntitySpecies.List()),
                Randomizer.GetRandom(EntityOccupation.List()));
        }
    }
}
