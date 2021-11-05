using RpgV2.Factories;
using RpgV2.GameMangement;
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
            var aGame = new Game();
            aGame.Run(3);

            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Done, press any key to close the console thank you...");
            Console.ReadLine();
        }
    }
}
