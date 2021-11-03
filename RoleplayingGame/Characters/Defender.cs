﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Defender : BaseCharacter
    {
        public Defender(string name, int hitPoints, int minDamage, int maxDamage)
            : base(name, hitPoints, minDamage, maxDamage)
        {
        }

        protected override int ReceiveDamageModifyChance
        {
            get { return 45; }
        }

        protected override int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return receivedDamage / 2;
        }
    }
}