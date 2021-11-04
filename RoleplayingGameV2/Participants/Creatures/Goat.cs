namespace RoleplayingGameV2.Participants.Creatures
{
    public class Goat : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 25;
        public const int MELEE_MAX_DAMAGE = 20;

        public Goat() : base(MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}
