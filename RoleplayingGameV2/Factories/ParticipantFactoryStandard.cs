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
            return index switch
            {
                1 => new Bear(),
                2 => new Goat(),
                3 => new Snake(),
                4 => new Wolf(),
                5 => new Golem(GenerateName()),
                6 => new Troll(GenerateName()),
                _ => throw new Exception($"Could not generate participant with index {index}"),
            };
        }

        private string GenerateName()
        {
            var generator = new List<string>() { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "vaar", "der", "Vi", "ct", "or" };
            var name = generator[RNG.RandomInt(0, generator.Count - 1)] 
                        + generator[RNG.RandomInt(0, generator.Count - 1)] 
                        + generator[RNG.RandomInt(0, generator.Count - 1)];
            var formattedName = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);

            if(formattedName == "Victor")
            {
                Console.WriteLine($"A awesome humanoid has been created with the victorious name: {formattedName}");
                //throw new Exception("Awesome name!");
            }

            return formattedName;
        }
    }
}
