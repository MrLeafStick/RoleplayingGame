namespace RolePlayingGameV2.Participants.Creatures
{
    public class Bear : CreatureBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 75;
        public const int MAX_MELEE_DAMAGE = 25;

        public Bear() : base(MAX_INITIAL_HEALTH_POINTS, MAX_MELEE_DAMAGE){}
    }
}
