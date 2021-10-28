﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Damager : Character
    {
        #region Constructors
        public Damager(string name, int maxHitPoints, int minDamage, int maxDamage) 
            : base(name, maxHitPoints, minDamage, maxDamage)
        {

        }
        #endregion

        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        protected override int CalculateModifedDamage(int dealtDamage)
        {
            return dealtDamage * 2;
        }
    }
}