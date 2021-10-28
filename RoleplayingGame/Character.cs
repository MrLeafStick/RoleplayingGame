using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Character
    {
        #region instance fields
        private string _name;
        protected int _hitPoints;
        protected int _maxHitpoints;
        protected int _minDamage;
        protected int _maxDamage;

        #endregion

        #region Constructor
        public Character(string name, int hitPoints, int maxHitpoints, int minDamage, int maxDamage)
        {
            _name = name;
            _hitPoints = hitPoints;
            _maxHitpoints = maxHitpoints;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public bool IsDead
        {
            get { return (_hitPoints <= 0); }
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

        public int RecieveDamage()
        {
            return 0;
        }

        public void LogSurvivor()
        {
            if(!IsDead)
            {
                
            }
        }

        public int DealDamageModify(int DealtDamage)
        {
            return 0;
        }

        public int ReceiveDamageModify(int reciveDamage)
        {
            return 0;
        }
        #endregion

        #region Virtual Properties and Methods
        protected virtual int DealDamageModifyChange
        {
            get { return 0; }
        }
        
        protected virtual int ReceiveDamageModifyChange
        {
            get { return 0; }
        }

        protected virtual itn CalculateModifiedReceivedDamage(int dealtDamage)
        {
            return dealtDamage;
        }
        
        protected virtual itn CalculateModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage;
        }
        #endregion
    }
}
