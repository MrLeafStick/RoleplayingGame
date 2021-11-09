using RPG_V3.Entities;
using RPG_V3.Helpers;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Factories
{
    public class CritterFactoryStandard : ICritterFactory
    {
        public ICritter CreateCritter()
        {
            return new Critter(
                Randomizer.GenerateName(),
                Randomizer.GetRandom(EntityCategory.List()),
                Randomizer.GetRandom(EntitySpecies.List()));
        }
    }
}
