using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Battle log:");
            Console.WriteLine( new string('=', 40));

            foreach(string s in _log)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Reset()
        {
            _log.Clear();
        }

    }
}
