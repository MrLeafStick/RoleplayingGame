namespace RolePlayingGameV2.Participants
{
    public class Character : ParticipantBase
    {
        public const int MAX_INITIAL_HEALTHPOINTS = 500;
        public const int MAX_INITIAL_GOLD = 100;
        public const int MAX_INITIAL_ARMOR = 3;
        public const int MAX_INITIAL_WEAPONS = 2;
        public const int MAX_DAMAGE = 50;

        public Character(string name) : 
            base(MAX_INITIAL_HEALTHPOINTS, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPONS, MAX_DAMAGE, name){}
        public int Level { get; private set; }
        public void LevelUp() 
        {
            Level++;
        }
    }
}
//TODO when our character dies i want something to happen...