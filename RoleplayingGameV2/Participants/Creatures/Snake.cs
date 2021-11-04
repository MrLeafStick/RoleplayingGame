namespace RoleplayingGameV2.Participants.Creatures
{
    public class Snake : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 40;
        public const int MELEE_MAX_DAMAGE = 10;

        public Snake() : base(MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}
