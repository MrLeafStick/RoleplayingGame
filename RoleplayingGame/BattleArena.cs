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
                groupB.ReceiveDamage(groupA.DealDamage());

                if(!groupA.IsDead)
                {
                    groupA.ReceiveDamage(groupB.DealDamage());
                }
            }
            Battlelog.Save($"{new string('=', 20)} BATTLE IS OVER {new string('=', 20)}");
            Battlelog.Save($"{(groupA.IsDead ? groupB.GroupName : groupA.GroupName)} Won! status:");
            groupA.LogSurvivor();
            groupB.LogSurvivor();

            Battlelog.PrintLog();
        }
    }
}
