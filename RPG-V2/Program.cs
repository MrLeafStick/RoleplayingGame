using RPG_V2.Factories;
using RPG_V2.GameManagement;
using System;

namespace RPG_V2
{
    class Program
    {
        static void Main()
        {
            GameFactory.Instance().ArmorFactory = new ArmorFactoryStandard();
            GameFactory.Instance().WeaponFactory = new WeaponFactoryStandard();
            GameFactory.Instance().ParticipantFactory = new ParticipantFactoryStandard();

            Game aGame = new Game();
            aGame.Run(5);

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
