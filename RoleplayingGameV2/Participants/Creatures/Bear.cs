﻿namespace RoleplayingGameV2.Participants.Creatures
{
    public class Bear : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 70;
        public const int MELEE_MAX_DAMAGE = 25;

        public Bear() : base(MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}
