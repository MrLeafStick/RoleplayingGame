using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame

{
    public class Character
    {
        #region Instance Fields
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
        protected virtual int DealDamageModifyChange
        {
            get { return 0; }
        }

        protected virtual int ReceiveDamageModifyChance 
        { 
            get { return 0; } 
        }

        protected virtual int CalculatedModifiedDamage(int dealtDamage)
        {
            return dealtDamage;
        }

        protected virtual int CalculatedModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage;
        }
        #endregion
    }
}
