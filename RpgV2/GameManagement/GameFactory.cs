using RpgV2.Interfaces.Factories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.GameManagement
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
