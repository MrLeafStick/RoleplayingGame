﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{    /// <summary>
     /// This class represents a group of game characters
     /// </summary>
    public class BaseCharacterGroup
    {
        #region Instance Field
        private List<BaseCharacter> _group;
        private string _groupName;
        #endregion

        #region Constructor
        public BaseCharacterGroup(string groupName)
        {
            _group = new List<BaseCharacter>();
            _groupName = groupName;
        }
        #endregion

        #region Propertiess
        public string GroupName 
        {
            get { return _groupName; }
        }

        /// <summary>
        /// Dead is defined as: All members of the group must be dead
        /// </summary>
        public bool IsDead 
        {
            get
            {
                foreach(BaseCharacter member in _group)
                {
                    if (!member.IsDead)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add one BaseCharacter to the group 
        /// </summary>
        public void AddBaseCharacter(BaseCharacter aBeast)
        {
            _group.Add(aBeast);
        }
        /// <summary>
        /// DealDamage is defined as: the total damage dealt by 
        /// all non-dead members of the group
        /// </summary>
        public int DealDamage()
        {
            int totalDamage = 0;

            foreach (BaseCharacter member in _group)
            {
                if (!member.IsDead)
                {
                    totalDamage = totalDamage + member.DealDamage();
                }
            }

            return totalDamage;
        }


        /// <summary>
        /// ReceiveDamage is defined as: the first non-dead 
        /// member in the list receives all of the damage
        /// </summary>
        public void ReceiveDamage(int damage)
        {
            foreach(BaseCharacter member in _group)
            {
                if (!member.IsDead)
                {
                    member.ReceiveDamage(damage);
                    return;
                }
            }
        }

        public void LogSurvivor()
        {
            foreach (BaseCharacter member in _group)
            {
                if (!member.IsDead)
                {
                    member.LogSurvivor();
                }
            }
        }


        #endregion
    }
}
