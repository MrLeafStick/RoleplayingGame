using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Wizard : Character
    {
        public Wizard(string name, int hitPoints, int minDamage, int maxDamage) 
            : base(name, hitPoints, minDamage, maxDamage)
        {
        }

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
            get { return 30; }
        }

        protected override int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return (int)Math.Floor(receivedDamage / 2.5);
        }
    }
}
