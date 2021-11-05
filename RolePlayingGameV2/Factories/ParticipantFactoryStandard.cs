using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;
using RolePlayingGameV2.Interfaces.Factories;
using RolePlayingGameV2.Participants.Creatures;
using RolePlayingGameV2.Participants.Humanoids;
using System;
using System.Collections.Generic;

namespace RolePlayingGameV2.Factories
{
    public class ParticipantFactoryStandard : IParticipantFactory
    {
        public IParticipant CreateParticipant()
        {
            int index = RNG.RandomInt(1, 6);

            switch (index)
            {
                case 1 : return new Bear();
                case 2 : return new Goat();
                case 3 : return new Snake();
                case 4 : return new Wolf();
                case 5 : return new Golem(GenerateName());
                case 6 : return new Troll(GenerateName());
                default:
                    throw new Exception($"Could not generate participant with index {index}");
            }
        }

        private string GenerateName() 
        {
            var generator = new List<string> { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "vaar" };
            var name = generator[RNG.RandomInt(0, generator.Count-1)] +
                       generator[RNG.RandomInt(0, generator.Count-1)] +
                       generator[RNG.RandomInt(0, generator.Count-1)];
            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            return name;
        }
    }
}
