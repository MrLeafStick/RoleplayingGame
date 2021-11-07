using RPG_V3.Entities;
using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_V3.Factories
{
    public class EntityFactoryStandard : IEntityFactory
    {
        public IEntity CreateParticipant()
        {
            return new Entity(
                GenerateName(), 
                GetRandom(EntityType.List(), RNG._generator), 
                GetRandom(EntitySpecies.List(), RNG._generator), 
                GetRandom(EntityOccupation.List(), RNG._generator));
        }

        private string GenerateName()
        {
            List<string> generator = new List<string> { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "zor", "vaar", "khon", "an", "bel", "lin" };

            var name = generator[RNG.RandomInt(0, generator.Count - 1)] +
                       generator[RNG.RandomInt(0, generator.Count - 1)] +
                       generator[RNG.RandomInt(0, generator.Count - 1)];

            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            return name;
        }

        T GetRandom<T>(List<T> list, Random random)
        {
            return list.ElementAt(random.Next(0, list.Count));
        }
    }
}
