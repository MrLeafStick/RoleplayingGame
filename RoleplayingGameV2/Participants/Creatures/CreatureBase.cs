namespace RoleplayingGameV2.Participants.Creatures
{
    public class CreatureBase : ParticipantBase
    {
        public const int MaxInitialItem = 3;

        public CreatureBase(int maxInitialHealthPoints, double maxDamage) 
            : base(maxInitialHealthPoints, 0, MaxInitialItem, maxDamage, "")
        {
        }

        public override string Name
        {
            get { return GetType().Name; }
        }
    }
}
