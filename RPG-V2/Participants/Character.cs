namespace RPG_V2.Participants
{
    public class Character : ParticipantBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 400;
        public const int MAX_INITIAL_GOLD = 100;
        public const int MAX_INITIAL_ARMOR = 5;
        public const int MAX_INITIAL_WEAPONS = 5;
        public const int MAX_DAMAGE = 40;

        public Character(string name)
            : base(MAX_INITIAL_HEALTH_POINTS, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPONS, MAX_DAMAGE, name)
        {
        }

        public int Level { get; private set; }

        public void LevelUp()
        {
            Level++;
        }

    }
}

// TODO: When our character dies I want something to happen
