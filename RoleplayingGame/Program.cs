using System;

namespace RoleplayingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.AbilityType d = new Test.AbilityType();

            var mech = new GameMechanics();
            mech.GameLogic();
        }
    }
}
