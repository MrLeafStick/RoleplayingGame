using System;
using RolePlayingGameV2.Core;

namespace RolePlayingGameV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Game = new Game();
            Game.Run();

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
