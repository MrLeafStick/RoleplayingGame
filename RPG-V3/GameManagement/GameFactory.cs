using RPG_V3.Factories;
using RPG_V3.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V3.GameManagement
{
    public class GameFactory
    {
        private static GameFactory _instance;

        public IArmorFactory ArmorFactory { get; set; }
        public IWeaponFactory WeaponFactory { get; set; }
        public IEntityFactory ParticipantFactory { get; set; }

        public static GameFactory Instance()
        {
            return _instance ?? (_instance = new GameFactory());
        }

        private GameFactory()
        {
        }
    }
}
