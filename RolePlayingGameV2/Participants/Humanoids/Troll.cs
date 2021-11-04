namespace RolePlayingGameV2.Participants.Humanoids
{
    public class Troll : HumanoidBase
    {
        public const int MAX_DAMAGE = 200;
        public const int MAX_HEALTH_POINTS = 80;

        public Troll(string name) : base(MAX_HEALTH_POINTS, MAX_DAMAGE, name)
        {
        }
    }
}
