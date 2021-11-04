using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Interfaces
{
    public interface IWeapon : IItem
    {
        int MaxWeaponDamage { get; }
        int MinWeaponDamage { get; }

    }
}
