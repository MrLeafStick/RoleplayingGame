using RPG_V3.Interfaces;

namespace RPG_V3.Entities
{
    public class Critter : Entity, ICritter
    {
        public Critter(string name, EntityCategory category, EntitySpecies species) 
            : base(name, category, species)
        {

        }
    }
}
