using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Interfaces.Factories;
using RoleplayingGameV2.Participants.Creatures;
using RoleplayingGameV2.Participants.Humanoids;
using System;
using System.Collections.Generic;

namespace RoleplayingGameV2.Factories
{
    public class ParticipantFactoryStandard : IParticipantFactory
    {
        public IParticipant CreateParticipant()
        {
            int index = RNG.RandomInt(1, 6);
            switch (index)
            {
                case 1: return new Bear();
                case 2: return new Goat();
                case 3: return new Snake();
                case 4: return new Wolf();
                case 5: return new Golem(GenerateName());
                case 6: return new Troll(GenerateName());
                default: throw new Exception($"Could not generate participant with index {index}");
            }
        }

        private string GenerateName()
        {
            var generator = new List<string>() { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "vaar", "der", "Vi", "ct", "or" };
            var name = generator[RNG.RandomInt(0, generator.Count)] 
                        + generator[RNG.RandomInt(0, generator.Count)] 
                        + generator[RNG.RandomInt(0, generator.Count)];
            var formattedName = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            if(formattedName == "Victor")
            {
                throw new Exception("Awesome name!");
            }

            return formattedName;
        }
    }
}
