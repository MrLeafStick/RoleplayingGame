using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Character
    {
        #region Instance fields
        private string _name;
        protected int _hitPoints;
        protected int _maxHitpoints;
        protected int _minDamage;
        protected int _maxDamage;
        #endregion

        #region Constructor
        public Character(string name,
                            int hitPoints,
                            int maxHitpoints,
                            int minDamage,
                            int maxDamage
        )

        {
            _name = name;
            _hitPoints = hitPoints;
            _maxHitpoints = maxHitpoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            Reset();
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name;  }
        }

        public bool IsDead
        {
            get { return (_hitPoints <= 0);  }
        }
        #endregion

        #region Methods
        public void Reset()
        {
            _hitPoints = _maxHitpoints;
        }

        public int DealDamage()
        {
            return 0;
        }

        public int ReciveDamage()
        {
            return 0;
        }

        public void LogSurvivor()
        {
            if (!IsDead)
            {

            }
        }

        public int DealDamageModifier(int dealtDamage)
        {
            return 0;
        }

        public int ReciveDamageModifier(int reciveDamage)
        {
            return 0;
        }

        #endregion

        #region Virtual Properties and Methods

        #endregion
    }
}
