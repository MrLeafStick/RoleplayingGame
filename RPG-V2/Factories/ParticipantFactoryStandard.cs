using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Interfaces.Factories;
using RPG_V2.Participants.Creatures;
using RPG_V2.Participants.Humanoids;
using System;
using System.Collections.Generic;

namespace RPG_V2.Factories
{
    public class ParticipantFactoryStandard : IParticipantFactory
    {
        public IParticipant CreateParticipant()
        {
            int index = RNG.RandomInt(1, 8);

            return index switch
            {
                1 => new Bear(),
                2 => new Goat(),
                3 => new Snake(),
                4 => new Wolf(),
                5 => new Golem(GenerateName()),
                6 => new Troll(GenerateName()),
                7 => new Ghoul(GenerateName()),
                8 => new Skeleton(GenerateName()),
                _ => throw new Exception($"Could not generate item with index {index}"),
            };
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

    }
}
