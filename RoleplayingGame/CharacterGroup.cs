﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class CharacterGroup 
    {
        #region Instance Fields
        private List<BaseCharacter> _group;
        private string _groupName;
        private Random _random;
        private ConsoleColor _color;
        #endregion

        #region Constructors
        public CharacterGroup(string groupName, ConsoleColor color)
        {
            _group = new List<BaseCharacter>();
            _groupName = groupName;
            _random = new Random();
            _color = color;
        }
        #endregion

        #region Propertes
        public string GroupName { get { return _groupName; } }
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
        public void AddCharacter(BaseCharacter aBeast)
        {
            _group.Add(aBeast);
        }

        public int DealDamage()
        {
            int totalDamage = 0;

            foreach(BaseCharacter member in _group)
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
            while(true)
            { 
                var randomMember = _random.Next(0, _group.Count());
                BaseCharacter member = _group.ElementAt(randomMember);

                if (!member.IsDead)
                {
                    member.ReceiveDamage(damage);
                    return;
                }
            }
        }

        public void Regenerate()
        {
            foreach (BaseCharacter member in _group)
            {
                if (!member.IsDead)
                {
                    member.Regenerate();
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
