using System;

namespace RPG_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game aGame = new Game();
            aGame.Run();

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
