namespace RoleplayingGameV2.Participants.Creatures
{
    public class Wolf : CreatureBase
    {
        public const int MaxInitialHealthPoint = 60;
        public const int MaxDamage = 18;

        public Wolf() : base(MaxInitialHealthPoint, MaxDamage)
        {
        }
    }
}
