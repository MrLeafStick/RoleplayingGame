namespace RolePlayingGameV2.Participants.Humanoids
{
    public class HumanoidBase : ParticipantBase
    {
        public const int MAX_INITIAL_GOLD = 50;
        public const int MAX_INITIAL_ARMOR = 4;
        public const int MAX_INITIAL_WEAPONS = 1;


        public HumanoidBase(int maxInitialHealthPoints, double maxDamage, string name) : base(maxInitialHealthPoints, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPONS, maxDamage, name)
        {
        }
    }
}
