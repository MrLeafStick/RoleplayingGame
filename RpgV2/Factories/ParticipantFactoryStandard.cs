﻿using RpgV2.Helpers;
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

            return index switch
            {
                1 => new Bear(),
                2 => new Goat(),
                3 => new Snake(),
                4 => new Wolf(),
                5 => new Golem(GenerateName()),
                6 => new Troll(GenerateName()),
                _ => throw new Exception($"Could not generate item with index {index}"),
            };
        } 

        private string GenerateName()
        {
            List<string> generator = new() { "xan", "tran", "ser", "mor", "houl", "zuur", "raz", "qex", "sir", "vaar" };
            var name = generator[RNG.RandomInt(0, generator.Count -1)] + 
                       generator[RNG.RandomInt(0, generator.Count -1)] + 
                       generator[RNG.RandomInt(0, generator.Count -1)];
            name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);
            return name;
        }

    }
}
