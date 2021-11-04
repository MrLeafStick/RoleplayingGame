namespace RoleplayingGameV2.Participants.Creatures
{
    public class Wolf : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 60;
        public const int MELEE_MAX_DAMAGE = 18;

        public Wolf() : base(MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}
