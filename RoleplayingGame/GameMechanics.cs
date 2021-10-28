using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class GameMechanics
    {
        public void GameLogic()
        {
            var swordA = new Sword("Slayer OF DOOOOOM", 20, 50);
            var swordB = new Sword("Tiny Stick", 1, 5);


            var warriorA = new Warrior("Ragnar", 200, swordB);
            var warriorB = new Warrior("Sighurd", 240, swordA);

            Console.WriteLine("Just after creation:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();

            int damageFromA = warriorA.DealDamage();
            int damageFromB = warriorB.DealDamage();
            warriorA.ReceiveDamage(damageFromB);
            warriorB.ReceiveDamage(damageFromA);

            Console.WriteLine("After damage:");
            Console.WriteLine(warriorA.GetInfo());
            Console.WriteLine(warriorB.GetInfo());
            Console.WriteLine();


        }
    }
}
