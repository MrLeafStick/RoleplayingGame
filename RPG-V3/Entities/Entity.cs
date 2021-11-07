using RPG_V3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Entities
{
    public class Entity : IEntity
    {
        public Entity(string name, EntityType type, EntitySpecies species, EntityOccupation occupation)
        {
            Name = name;
            Type = type;
            Species = species;
            Occupation = occupation;
        }

        public EntityType Type { get; }
        public EntitySpecies Species { get; }
        public EntityOccupation Occupation { get; }
        public string Name { get; }
        public int GoldOwned { get; set; }
        public double HealthPoints { get; }
        public bool IsDead { get { return HealthPoints <= 0.0 ? true : false; } }

        public override string ToString()
        {
            var entityString = $"{Name} the {(Type.Name == "Living" ? "\b" : Type.Name)}{(Type.Name == "Were" ? "-" : " ")}{Species.Name} is {Occupation.Name}";

            return entityString;
        }
    }


}
