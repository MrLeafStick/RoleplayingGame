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
            
            Console.WriteLine($"Warrior A is called {warriorA.Name}, " +
                $"and is level {warriorA.Level}, " +
                $"and has {warriorA.HitPoints} hit points (Dead = {warriorA.IsDead})");
            Console.WriteLine($"Warrior A is called {warriorB.Name}, " +
                $"and is level {warriorB.Level}" +
                $"and has {warriorB.HitPoints} hit points (Dead = {warriorB.IsDead})");

            Console.WriteLine();
            Console.WriteLine("=======================================");

            Console.WriteLine($"X hits {warriorA.Name}");
            Console.WriteLine($"y hits {warriorB.Name}");

            Console.WriteLine();
            Console.WriteLine("=======================================");


            warriorA.ReceiveDamage(180);
            warriorB.ReceiveDamage(180);
            
            Console.WriteLine("After first hit");
            Console.WriteLine($"{warriorA.Name}, " +
                $"got hit by a huge Axe and now has {warriorA.HitPoints} " +
                $"left. is he dead ? {warriorA.IsDead}");
            Console.WriteLine($"{warriorB.Name}, " +
                $"got hit by a huge Axe and now has {warriorB.HitPoints} " +
                $"left. is he dead ? {warriorB.IsDead}");
            Console.WriteLine();
            Console.ReadLine();


            Console.WriteLine("=======================================");

            warriorA.ReceiveDamage(50);
            warriorB.ReceiveDamage(50);

            Console.WriteLine("After second hit");
            Console.WriteLine($"{warriorA.Name}, " +
                $"got hit by a huge Axe and now has {warriorA.HitPoints} " +
                $"left. is he dead ? {warriorA.IsDead}");
            Console.WriteLine($"{warriorB.Name}, " +
                $"got hit by a huge Axe and now has {warriorB.HitPoints} " +
                $"left. is he dead ? {warriorB.IsDead}");
            Console.WriteLine();

            Console.WriteLine("=======================================");
            Console.ReadLine();

            if (warriorA.IsDead)
            {
                Console.WriteLine($"RIP {warriorA.Name}");
            }else if (warriorB.IsDead)
            {
                Console.WriteLine($"RIP {warriorB.Name}");
            }
            else
            {
                Console.WriteLine($"I WILL SURVIVE !!!");
            }




            warriorA.LevelUp();
            warriorB.LevelUp();
            warriorB.LevelUp();
            warriorB.LevelUp();

            Console.WriteLine($"*** A DING is heard in the distance ***");
            Console.WriteLine();

            Console.WriteLine($"Warrior A is called {warriorA.Name}, " +
                 $"and is now level {warriorA.Level}");           
            Console.WriteLine($"Warrior B is called {warriorB.Name}, " +
                 $"and is now level {warriorB.Level}");

            Console.WriteLine();



        }
    }
}
