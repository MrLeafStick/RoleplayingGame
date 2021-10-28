using System;
using System.Collections.Generic;

namespace RoleplayingGame
{
    public static class BattleLog
    {
        private static List<string> _log = new List<string>();

        public static void Save(string message)
        {
            _log.Add(message);
        }

        public static void PrintLog()
        {
            Console.WriteLine("Battle Log :");
            Console.WriteLine(new string('=', 40));
            foreach (var message in _log)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine(new string('=', 40));
            Console.WriteLine();
        }

        public static void Reset()
        {
            _log.Clear();
        }
    }
}
