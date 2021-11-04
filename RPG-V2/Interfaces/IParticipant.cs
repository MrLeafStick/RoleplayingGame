using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Interfaces
{
    public interface IParticipant
    {
        public string Name { get; }
        public double HealthPoints { get; }
        public bool IsDead { get; }
        public int GoldOwned { get; set; }
        List<IArmor> ArmorOwned { get; } 
        List<IWeapon> WeaponsOwned { get; }

        double DealDamage();
        void ReceiveDamage(double damagePoints);
    }
}
