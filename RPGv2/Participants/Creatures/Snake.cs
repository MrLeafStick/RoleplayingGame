﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Participants.Creatures
{
    public class Snake : CreatureBase
    {
        public const int MaxInitialHealthPoints = 40;
        public const int MaxDamage = 10;

        public Snake(int maxInitialHealthPoints, double maxDamage) : base(maxInitialHealthPoints, maxDamage)
        {
        }
    }
}