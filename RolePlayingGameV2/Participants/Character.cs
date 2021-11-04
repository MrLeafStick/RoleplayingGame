namespace RolePlayingGameV2.Participants
{
    public class Character : ParticipantBase
    {
        public const int MAX_INITIAL_HEALTHPOINTS = 500;
        public const int MAX_INITIAL_GOLD = 100;
        public const int MAX_INITIAL_ITEMS = 5;
        public const int MAX_DAMAGE = 50;

        public Character(string name) : base(MAX_INITIAL_HEALTHPOINTS, MAX_INITIAL_GOLD, MAX_INITIAL_ITEMS, MAX_DAMAGE, name)
        {
        }

        public int Level { get; private set; }

        public void LevelUp() 
        {
            Level++;
        }
    }
}

//TODO when out character dies i want something to happen...