using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class Priest : Character
    {
        public Priest(string name, int hitPoints, int minDamage, int maxDamage) 
            : base(name, hitPoints, minDamage, maxDamage)
        {
        }

        protected override int ReceiveDamageModifyChance
        {
            get { return 70; }
        }

        protected override int CalculateModifedReceivedDamage(int receivedDamage)
        {
            return (int)Math.Floor(receivedDamage / 3.0);
        }
    }
}
