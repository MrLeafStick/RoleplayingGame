using RPG_V3.Entities;
using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;

namespace RPG_V3.Factories
{
    public class EntityFactoryStandard : IEntityFactory
    {
        public IEntity CreateEntity()
        {
            return new Entity(
                Randomizer.GenerateName(),
                Randomizer.GetRandom(EntityCategory.List()),
                Randomizer.GetRandom(EntitySpecies.List()),
                Randomizer.GetRandom(EntityOccupation.List()));
        }
    }
}
