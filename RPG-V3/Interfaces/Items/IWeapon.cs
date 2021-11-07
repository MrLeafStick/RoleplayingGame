using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.Interfaces
{
    public interface IWeapon : IItem
    {
        public double MaxDamagePoints { get; }
        public double MinDamagePoints { get; }
    }
}
