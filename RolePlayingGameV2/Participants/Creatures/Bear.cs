namespace RolePlayingGameV2.Participants.Creatures
{
    public class Bear : CreatureBase
    {
        public const int MaxInitialHealthPoints = 75;
        public const int MaxDamage = 25;

        public Bear() : base(MaxInitialHealthPoints, MaxDamage)
        {
        }
    }
}
