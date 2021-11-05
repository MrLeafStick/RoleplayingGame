using RpgV2.Interfaces;

namespace RpgV2.Participants.Creatures
{
    internal class Goat : CreatureBase 
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 25;
        public const int MELEE_MAX_DAMAGE = 20;

        public Goat() : base(MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}