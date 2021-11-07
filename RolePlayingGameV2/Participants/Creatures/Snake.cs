namespace RolePlayingGameV2.Participants.Creatures
{
    public class Snake : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 40;
        public const int MAX_MELEE_DAMAGE = 10;

        public Snake() : base(MAX_INITIAL_HEALTH_POINTS, MAX_MELEE_DAMAGE){}
    }
}
