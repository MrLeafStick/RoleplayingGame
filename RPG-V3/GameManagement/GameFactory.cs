using RPG_V3.Interfaces.Factories;

namespace RPG_V3.GameManagement
{
    public class GameFactory
    {
        private static GameFactory _instance;

        public IArmorFactory ArmorFactory { get; set; }
        public IWeaponFactory WeaponFactory { get; set; }
        public IEntityFactory EntityFactory { get; set; }
        public ICharacterFactory CharacterFactory { get; set; }
        public ICritterFactory CritterFactory { get; set; }

        public static GameFactory Instance()
        {
            return _instance ?? (_instance = new GameFactory());
        }

        private GameFactory()
        {
        }
    }
}
