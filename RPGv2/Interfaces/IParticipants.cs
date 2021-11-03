using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Interfaces
{
    public interface IParticipants
    {
        string Name { get; }
        double HealthPoints { get; }
        bool isDead { get; }
        int GoldOwned { get; }
        List<IItems> ItemsOwned { get; }
        double DealDamage();
        void ReceiveDamage(double damagePoints);


    }
}
