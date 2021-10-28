using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class CharacterGroup
    {
        #region Instance Field
        private List<Character> _group;
        private string _groupName;


        #endregion

        #region Constructor
        public CharacterGroup(global::System.String groupName)
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
                foreach(Character member in _group)
                {
                    if(!member.IsDead)
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

            foreach(Character memeber in _group)
            {
                if(!memeber.IsDead)
                {
                    totalDamage = totalDamage + memeber.DealDamage();
                }
            }

            return totalDamage;
        }

        public void ReceiveDamage(int damage)
        {
            foreach(Character member in _group)
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
            foreach (Character member in _group)
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
