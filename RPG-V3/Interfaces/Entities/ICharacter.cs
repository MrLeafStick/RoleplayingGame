using RPG_V3.Entities;
using System.Collections.Generic;

namespace RPG_V3.Interfaces
{
    public interface ICharacter : IEntity
    {
        public EntityOccupation Occupation { get; }

        public int GoldOwned { get; set; }

        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }
    }
}
