using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    /// <summary>
    /// This class implements a simple logging system, where strings can be collected
    /// one by one. The entire set of strings can then be printed.
    /// </summary>
    public static class BattleLog
    {
        private static readonly List<string> _log = new List<string>();

        //Save a sinlge string

        public static void Save(string message)
        {
            _log.Add(message);
        }
        //Print all(History )
        public static void PrintLog()
        {
            Console.WriteLine("Battle Log :");
            Console.WriteLine(new string('=', 40));
            foreach(string s in _log)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        //Clear everything from log
        public static void Reset()
        {
            _log.Clear();
        }

    }

}
