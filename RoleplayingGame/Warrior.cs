using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Warrior
    {
        #region Instance Fields
        private string _name;
        private int _level;
        private int _hitPoints;
        private Sword _sword;
        #endregion

        #region Constructor
        public Warrior(string name, int hitPoints, Sword sword)
        {
            _name = name;
            _hitPoints = hitPoints;
            _level = 1;
            _sword = sword;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
        }
        public bool IsDead
        {
            get { return _hitPoints <= 0; }
        }


        #endregion

        #region Methods
        public void LevelUp()
        {
            _level = _level + 1;
        }

        public void ReceiveDamage(int points)
        {
            _hitPoints = _hitPoints - points;
        }

        public int DealDamage()
        {
            return 0;
        }

        public string GetInfo()
        {
            return $"{Name} has {HitPoints} hit points ({(IsDead ? "dead" : "alive")})";
        }

        #endregion

    }
}
