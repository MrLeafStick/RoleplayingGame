using RPG_V2.Interfaces.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.GameManagement
{
    public class GameFactory
    {
        private static GameFactory _instance;

        public IArmorFactory ArmorFactory { get; set; }
        public IWeaponFactory WeaponFactory { get; set; }
        public IParticipantFactory ParticipantFactory { get; set; }

        public static GameFactory Instance()
        {
            return _instance ?? (_instance = new GameFactory());
        }

        private GameFactory()
        {

        }
    }
}
