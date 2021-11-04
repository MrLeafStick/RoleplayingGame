using RolePlayingGameV2.Interfaces.Factories;

namespace RolePlayingGameV2.GameManagement
{
    public class GameFactory
    {
        private static GameFactory _instance;

        public IArmorFactory ArmorFactory { get; set; }
        public IWeaponFactory WeaponFactory { get; set; }
        public IParticipantFactory participantFactory { get; set; }

        public static GameFactory Instance() 
        {
            return _instance ?? (_instance = new GameFactory());
        }

        private GameFactory() 
        {
        }
    }
}
