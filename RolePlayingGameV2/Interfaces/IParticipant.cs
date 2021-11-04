using System.Collections.Generic;

namespace RolePlayingGameV2.Interfaces
{
    public interface IParticipant
    {
        string Name { get; }
        double HealthPoints { get; }
        bool IsDead { get; }
        int GoldOwned { get; set; }
        List<IArmor> ArmorOwend { get; }
        List<IWeapon> WeaponsOwned { get; }
        List<IItem> ItemsOwned { get; }
        double DealDamage();
        void ReceiveDamage(double damagePoints);
    }
}
