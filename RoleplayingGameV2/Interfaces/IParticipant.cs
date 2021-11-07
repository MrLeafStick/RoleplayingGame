﻿using System.Collections.Generic;

namespace RoleplayingGameV2.Interfaces
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
        void ClearItems();
    }
}
