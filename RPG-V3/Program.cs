using RPG_V3.Factories;
using RPG_V3.GameManagement;
using System;

namespace RPG_V3
{
    class Program
    {
        static void Main()
        {
            GameFactory.Instance().ArmorFactory = new ArmorFactoryStandard();
            GameFactory.Instance().WeaponFactory = new WeaponFactoryStandard();
            GameFactory.Instance().ParticipantFactory = new EntityFactoryStandard();

            Game aGame = new Game();
            aGame.Run(4);

            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Done, press the any key to close cosole");
            Console.ReadKey();
        }
    }
}
