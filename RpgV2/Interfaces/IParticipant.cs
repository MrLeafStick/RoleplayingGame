using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Interfaces
{
    public interface IParticipant
    {
        string Name { get; }
        double HealthPoints { get; }
        bool IsDead { get; }
        int GoldOwned { get; set; }
        List<IArmor> ArmorOwned { get; }
        List<IWeapon> WeaponsOwned { get; }
        double DealDamage();
        void ReceiveDamage(double damagePoints);
    }
}


