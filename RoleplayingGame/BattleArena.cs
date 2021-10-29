namespace RoleplayingGame
{
    public class BattleArena
    {
        public static void DoBattle(CharacterGroup groupA, CharacterGroup groupB)
        {
            while(!groupA.IsDead && !groupB.IsDead)
            {
                groupB.ReceiveDamage(groupA.DealDamage());

                if (!groupA.IsDead)
                {
                    groupA.ReceiveDamage(groupB.DealDamage());
                }
            }
            BattleLog.Save($"{new string('=',20) } BATTLE IS OVER {new string('=',20)}");
            BattleLog.Save($"{(groupA.IsDead ? groupB.GroupName : groupA.GroupName) } Won! status:");
            groupA.LogSurvivor();
            groupB.LogSurvivor();

            BattleLog.PrintLog();
        }

    }
}
