namespace RoleplayingGameV2.Participants.Creatures
{
    public class Bear : CreatureBase
    {
        public const int MaxInitialHealthPoint = 70;
        public const int MaxDamage = 25;

        public Bear() : base(MaxInitialHealthPoint, MaxDamage)
        {
        }
    }
}
