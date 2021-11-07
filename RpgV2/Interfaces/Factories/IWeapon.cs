using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Interfaces.Factories
{
    public interface IWeapon : IItem
    {
        int TotalWeaponDamage { get; }
    }
}
