using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame

{
    public class Character
    {
        private string _name;
        protected int _hitPoints;
        protected int _minDamage;
        protected int _maxDamage;
        #endregion

        {
            _name = name;
            _hitPoints = hitPoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            Reset();
        }
        #endregion

        #region Properties

        public bool IsDead
        {
            get { return (_hitPoints <= 0); }
        }
        #endregion

        #region Methods
        {
        }

        public int DealDamage()
        {
            return 0;
        }

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

        {
            return 0;
        }

        #endregion

        #region Virtual Properties and Methods
        /// <summary>
        /// Return the change of the damage dealt being modifed, 
        /// unless overrides in a derived class, a charactor has 
        /// 0% chance of having the damage dealt modified.
        /// </summary>
        protected virtual int DealDamageModifyChange
        {
            get { return 0; }
        }

        { 
            get { return 0; } 
        }

        {
            return dealtDamage;
        }

        {
            return receivedDamage;
        }

        #endregion
    }
}
