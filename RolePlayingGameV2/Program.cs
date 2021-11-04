using System;
using RolePlayingGameV2.Factories;
using RolePlayingGameV2.GameManagement;

namespace RolePlayingGameV2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFactory.Instance().ArmorFactory = new ArmorFactoryStandard();
            GameFactory.Instance().WeaponFactory = new WeaponFactoryStandard();
            GameFactory.Instance().participantFactory = new ParticipantFactoryStandard();

            var Game = new Game();
            Game.Run(15);

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
