using System;

namespace RpgV2
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
            Console.WriteLine("Done, press the any key to close the console thank you...");
            Console.ReadKey();
        }
    }
}
