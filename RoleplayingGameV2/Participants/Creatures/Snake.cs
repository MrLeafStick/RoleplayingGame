namespace RoleplayingGameV2.Participants.Creatures
{
    public class Snake : CreatureBase
    {
        public const int MaxInitialHealthPoint = 40;
        public const int MaxDamage = 10;

        public Snake() : base(MaxInitialHealthPoint, MaxDamage)
        {
        }
    }
}
