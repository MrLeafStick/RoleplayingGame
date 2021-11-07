using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants
{
    class Character : ParticipantBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 100;
        public const int MAX_INITIAL_GOLD = 100;
        public const int MAX_INITIAL_ARMOR = 2;
        public const int MAX_INITIAL_WEAPONS = 7;
        public const int MAX_DAMAGE = 50;

        public Character(string name) 
            : base(MAX_INITIAL_HEALTH_POINTS, MAX_INITIAL_GOLD, MAX_INITIAL_ARMOR, MAX_INITIAL_WEAPONS, MAX_DAMAGE, name)
        {
        }

        public int Level { get; private set; }

        public void LevelUp()
        {
            Level++;
        }

        public string DeadCharacter()
        {
            string deathDescription = $"{this.Name} has died and lost all items.\n";
            deathDescription += $"\nGold lost: {this.GoldOwned}\n";
            deathDescription += $"\nArmor lost: \n";
            foreach (var armor in this.ArmorOwned)
            {
                deathDescription += $"{armor}\n";
            }

            deathDescription += $"\nWeapons lost: \n";

            foreach (var weapon in this.WeaponsOwned)
            {
                deathDescription += $"{weapon}\n";
            }

            return deathDescription;
        }
    }
}