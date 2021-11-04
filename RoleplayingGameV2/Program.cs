using System;

namespace RoleplayingGameV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Run();

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
