using RolePlayingGameV2.Interfaces;

namespace RolePlayingGameV2.Participants.Creatures
{
    public class Goat : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 25;
        public const int MAX_MELEE_DAMAGE = 20;

        public Goat() : base(MAX_INITIAL_HEALTH_POINTS, MAX_MELEE_DAMAGE){}
    }
}