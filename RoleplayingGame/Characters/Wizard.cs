using System;
using System.Collections.Generic;

namespace RoleplayingGame
{
    public class Wizard : BaseCharacter
    {
        #region Constructor
        public Wizard(string name, int hitPoints, int minDamage, int maxDamage)
            : base(name, hitPoints, minDamage, maxDamage)
        {
        }
        #endregion

        protected override int DealDamageModifyChance
        {
            get { return 80; }
        }

        protected override int CalculateModifedDamage(int dealtDamage)
        {
            return (int)Math.Floor(dealtDamage * 2.5);
        }

        protected override int ReceiveDamageModifyChance
        {
            get { return 10; }
        }

        protected override int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return (int)Math.Floor(receivedDamage / 2.5);
        }
    }
}
