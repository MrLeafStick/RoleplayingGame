﻿namespace RPG_V2.Participants.Humanoids
{
    public class Troll : HumanoidBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 200;
        public const int MAX_DAMAGE = 80;

        public Troll(string name)
            : base(name, MAX_INITIAL_HEALTH_POINTS, MAX_DAMAGE)
        {
        }
    }
}