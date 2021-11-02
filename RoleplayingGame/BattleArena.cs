using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class BattleArena
    {
        public static void DoBattle(CharacterGroup groupA, CharacterGroup groupB)
        {
            while(!groupA.IsDead && !groupB.IsDead)
            {
                BattleLog.Save(" ----------  Team Green attacks  ----------");

                groupB.ReceiveDamage(groupA.DealDamage());

                if(!groupA.IsDead)
                {
                    BattleLog.Save(" ----------  Team Red attacks  ----------");

                    groupA.ReceiveDamage(groupB.DealDamage());
                }

                groupA.Regenerate();
                groupB.Regenerate();
            }

            BattleLog.Save($" {new string('=', 20)} BATTLE IS OVER {new string('=',20)}");
            BattleLog.Save($"{ (groupA.IsDead ? groupB.GroupName : groupA.GroupName)} won! Status:");
            groupA.LogSurvivor();
            groupB.LogSurvivor();

            BattleLog.PrintLog();
        }
    }
}
