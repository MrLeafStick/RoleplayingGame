using RoleplayingGameV2.Factories;
using RoleplayingGameV2.GameManagement;
using System;

namespace RoleplayingGameV2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFactory.Instance.ArmorFactory = new ArmorFactoryStandard();
            GameFactory.Instance.WeaponFactory = new WeaponFactoryStandard();
            GameFactory.Instance.ParticipantFactory = new ParticipantFactoryStandard();

            var game = new Game();
            game.Run(900);

            KeepConsoleWindowOpen();
        }

        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Done, press any key to close the console.");
            Console.ReadLine();
        }
    }
}
