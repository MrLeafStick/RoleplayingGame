using RpgV2.Factories;
using RpgV2.GameManagement;

using System;

namespace RpgV2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFactory.Instance().ArmorFactory = new ArmorFactoryStandard();
            GameFactory.Instance().WeaponFactory = new WeaponFactoryStandard();
            GameFactory.Instance().ParticipantFactory = new ParticipantFactoryStandard();

            Game aGame = new Game();
            Game.Run(5);

            KeepConsoleWindowOpen(); 
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Done, press the any key to close the console thank you...");
            Console.ReadKey();
        }
    }
}
