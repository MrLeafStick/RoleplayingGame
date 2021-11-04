namespace RolePlayingGameV2.Participants.Humanoids
{
    public class HumanoidBase : ParticipantBase
    {
        public const int MAX_INITIAL_GOLD = 50;
        public const int MAX_INITIAL_ITEMS = 4;

        public HumanoidBase(int maxInitialHealthPoints, double maxDamage, string name) : base(maxInitialHealthPoints, MAX_INITIAL_GOLD, MAX_INITIAL_ITEMS, maxDamage, name)
        {
        }
    }
}
