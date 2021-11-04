using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Interfaces.Factories;
using RPG_V2.Participants.Creatures;
using RPG_V2.Participants.Humanoids;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Factories
{
    public class ParticipantFactoryStandard : IParticipantFactory
    {
        public IParticipant CreateParticipant()
        {
            int index = RNG.RandomInt(1, 6);

            switch(index)
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
                    return new Golem(GenerateName()); // TODO: generate name
                case 6:
                    return new Troll(GenerateName()); // TODO: generate name
                default:
                    throw new Exception($"Could not generate item with index {index}");
            }
        }

        private string GenerateName()
        {
            List<string> generator = new List<string> { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "vaar" };

            var name = generator[RNG.RandomInt(0, generator.Count)] +
                       generator[RNG.RandomInt(0, generator.Count)] +
                       generator[RNG.RandomInt(0, generator.Count)];

            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            return name;
        }
       
    }
}
