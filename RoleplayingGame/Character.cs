﻿using System;
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
        protected virtual int DealDamageModifyChange
        {
            get { return 0; }
        }

        /// <summary>
        /// Return the chance of the damage received bbeing modified.
        /// Unless overrieded in a dirived class, a Character has 
        /// 0% chance of having the damage received modified.
        /// </summary>
        protected virtual int ReceiveDamageModyChance
        {
            get { return 0; }
        }

        /// <summary>
        /// Return the modifed dealt damage.
        /// Unless overrisded in a dirived class, the modified dealt
        /// damage is the same as the original dealt damage.
        /// </summary
        protected virtual int CalculateModifedDamage(int dealtDamage)
        {
            return dealtDamage;
        }

        /// <summary>
        /// Return the modifed reveived damage.
        /// unless orverried in a derved class the modifed received
        /// damage is the sae as the original received damage.
        /// </summary>
        protected virtual int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return receivedDamage;
        }
        #endregion
    }
}
