using System.Collections.Generic;

namespace RoleplayingGameV2.Interfaces
{
    public interface IParticipant
    {
        string Name { get; }
        double HealthPoints { get; }
        bool IsDead { get; }
        int GoldOwned { get; set; }
        List<IItem> ItemsOwned { get; }

        double DealDamage();
        void ReceiveDamage(double damagePoints);
    }
}
