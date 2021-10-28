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
        protected int _maxHitPoints;
        protected int _minDamage;
        protected int _maxDamage;
        #endregion

        #region Constructor
        public Character(string name, int hitPoints, int maxHitPoints, int minDamage, int maxDamage)
        {
            _name = name;
            _hitPoints = hitPoints;
            _maxHitPoints = maxHitPoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            Reset();
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }        
        public bool IsDead
        {
            get { return _hitPoints <= 0; }
        }
        #endregion

        #region Methods
        public void Reset()
        {
            _hitPoints = _maxHitPoints;
        }
        public int DealDamage()
        {
            return 0;
        }
        public int ReceiveDamage()
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
        public int ReceiveDamageModifier(int receiveDamage)
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
        protected virtual int CalculateModifiedDamage(int dealtDamage)
        {
            return dealtDamage;
        }
        protected virtual int CalculateModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage;
        }
        #endregion
    }
}
