using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class CharacterGroup
    {
        #region Instance Fields
        private List<Character> _group;
        private string _groupName;
        #endregion

        #region Constructor
        public CharacterGroup(string groupName)
        {
            _group = new List<Character>();
            _groupName = groupName;
        }
        #endregion

        #region Properties
        public string GroupName
        {
            get { return _groupName; }
        }

        public bool IsDead
        {
            get
            {
                foreach (var member in _group)
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
        public void AddCharacter(Character aBeast)
        {
            _group.Add(aBeast);
        }

        public int DealDamage()
        {
            int totalDamage = 0;
            foreach (var member in _group)
            {
                if(!member.IsDead)
                {
                    totalDamage += member.DealDamage();
                }
            }
            return totalDamage;
        }

        public void ReceiveDamage(int damage)
        {
            foreach (var member in _group)
            {
                if(!member.IsDead)
                {
                    member.ReceiveDamage(damage);
                    return;
                }
            }
        }

        public void LogSurvivor()
        {
            foreach (var member in _group)
            {
                if(!member.IsDead)
                {
                    member.LogSurvivor();
                }
            }
        }
        #endregion
    }
}
