﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants.Humanoids
{
    public class HumanoidBase : ParticipantBase
    {
        // TODO: remove consts
        public const int MAX_INITIAL_GOLD = 50;
        public const int MAX_INITIAL_ITEMS = 4;
        public const int MAX_INITIAL_ARMOR = 4;
        public const int MAX_INITIAL_WEAPONS = 4;

        public HumanoidBase(string name, int maxInitialHealthPoints, double maxDamage) 
            : base(maxInitialHealthPoints, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPONS, maxDamage, name)
        {
        }
    }
}