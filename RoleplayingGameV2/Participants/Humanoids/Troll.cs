namespace RoleplayingGameV2.Participants.Humanoids
{
    public class Troll : HumanoidBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 200;
        public const double MELEE_MAX_DAMAGE = 80;

        public Troll(string name) : base(name, MAX_INITIAL_HEALTH_POINTS, MELEE_MAX_DAMAGE)
        {
        }
    }
}
