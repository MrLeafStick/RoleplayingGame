using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants
{
    class Character : ParticipantBase
    {
        public const int MAX_INITIAL_HEALTH_POINTS = 500;
        public const int MAX_INITIAL_GOLD = 100;
        public const int MAX_INITIAL_ITEMS = 5;
        public const int MAX_DAMAGE = 50;

        public Character(string name) 
            : base(MAX_INITIAL_HEALTH_POINTS, MAX_INITIAL_GOLD, MAX_INITIAL_ITEMS, MAX_DAMAGE, name)
        {
        }

        public int Level { get; private set; }

        public void LevelUp()
        {
            Level++;
        }


    }
}

//TODO: change char

//TODO: When our charactor dies i want something to happen(NOT BsOD)