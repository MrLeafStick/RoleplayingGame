namespace RoleplayingGameV2.Participants.Humanoids
{
    public class HumanoidBase : ParticipantBase
    {
        public const int MAX_INITIAL_GOLD = 50;
        public const int MAX_INITIAL_ARMOR = 2;
        public const int MAX_INITIAL_WEAPONS = 1;

        public HumanoidBase(string name, int maxInitialHealthPoints, double meleeMaxDamage) 
            : base(maxInitialHealthPoints, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPONS, meleeMaxDamage, name)
        {
        }
    }
}
