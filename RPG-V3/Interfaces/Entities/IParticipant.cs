using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Interfaces
{
    public interface IParticipant : IEntity
    {
        List<IArmor> ArmorOwned { get; } 
        List<IWeapon> WeaponsOwned { get; }

        double DealDamage();
        void ReceiveDamage(double damagePoints);
    }
}
