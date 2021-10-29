using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    class Ability
    {
        #region Field Definition
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _staminaCost;
        private int _manaCost;

        public Ability(string name, int minDamage, int maxDamage, int staminaCost, int manaCost)
        {
            _name = name;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _staminaCost = staminaCost;
            _manaCost = manaCost;
        }
        #endregion

        #region Constructors

        #endregion
    }
}
