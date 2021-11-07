﻿namespace RoleplayingGame
{
    public class BattleArena
    {
        public static void DoBattle(CharacterGroup groupA, CharacterGroup groupB)
        {
            while (!groupA.IsDead && !groupB.IsDead)
            {
                BattleLog.Save($" ------------  {groupA.GroupName} attacks  ------------");

                groupB.ReceiveDamage(groupA.DealDamage());

                if (!groupA.IsDead)
                {
                    BattleLog.Save($" ------------  {groupB.GroupName} attacks  ------------");

                    groupA.ReceiveDamage(groupB.DealDamage());
                }

                groupA.Regenerate();
                groupB.Regenerate();
            }

            BattleLog.Save($" {new string('=', 20)} BATTLE IS OVER {new string('=', 20)}");
            BattleLog.Save($"{ (groupA.IsDead ? groupB.GroupName : groupA.GroupName)} won! Status:");
            groupA.LogSurvivor();
            groupB.LogSurvivor();

            BattleLog.PrintLog();
        }
    }
}
