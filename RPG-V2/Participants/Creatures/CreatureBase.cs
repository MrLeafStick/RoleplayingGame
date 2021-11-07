﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants.Creatures
{
    public class CreatureBase : ParticipantBase
    {
        // TODO: remove consts
        public const int MAX_INITIAL_ARMOR = 2;
        public const int MAX_INITIAL_WEAPON = 0;

        public CreatureBase(int maxInitialHealthPoints, double maxDamage)
            : base(maxInitialHealthPoints, 0, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPON, maxDamage, "")
        {
        }

        public override string Name
        {
            get { return GetType().Name; }
        }
    }
}