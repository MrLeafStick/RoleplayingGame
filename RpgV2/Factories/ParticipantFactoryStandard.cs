using RpgV2.Helpers;
using RpgV2.Interfaces;
using RpgV2.Interfaces.Factories;
using RpgV2.Participants.Creatures;
using RpgV2.Participants.Humanoids;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Factories
{
    public class ParticipantFactoryStandard : IParticipantFactory
    {
        public IParticipant CreateParticipant()
        {
            int index = RNG.RandomInt(1, 6);

            switch (index)
            {
                case 1:
                    return new Bear();
                case 2:
                    return new Goat();
                case 3:
                    return new Snake();
                case 4:
                    return new Wolf();
                case 5:
                    return new Golem(GenerateName());
                case 6:
                    return new Troll(GenerateName());
                default:
                    throw new Exception($"Could not Generate item with index {index}");
            }

        }

        private string GenerateName()
        {
            List<string> generator = new List<string> { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "vaar" };
            var name = generator[RNG.RandomInt(0, (generator.Count - 1 ))] +
                       generator[RNG.RandomInt(0, (generator.Count - 1))] +
                       generator[RNG.RandomInt(0, (generator.Count - 1))];
            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            return name;
        }


    }
}
