﻿namespace RoleplayingGameV2.Participants
{
    public class Character : ParticipantBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 500;
        public const int MAX_INITIAL_GOLD = 100;
        public const int MAX_INITIAL_ARMOR = 3;
        public const int MAX_INITIAL_WEAPON = 2;
        public const double MELEE_MAX_DAMAGE = 50;

        public Character(string name) 
            : base(MAX_INITIAL_HEALTH_POINTS, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPON, MELEE_MAX_DAMAGE, name)
        {
        }

        public int Level { get; private set; }

        public void LevelUp()
        {
            Level++;
        }
    }
}

