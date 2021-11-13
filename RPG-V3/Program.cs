using RPG_V3.Factories;
using RPG_V3.GameManagement;
using System;

// TODO: calculate armor and weapon repair state as a function of number of uses and material strength
// TODO: Calculate weapon damage and armor points as a function of repair state and material strength
// TODO: Calculate damage given as a function of weapon damage points
// TODO: Calculate damage received as a function of armor armor points


namespace RPG_V3
{
    class Program
    {
        static void Main()
        {
            GameFactory.Instance().ArmorFactory = new ArmorFactoryStandard();
            GameFactory.Instance().WeaponFactory = new WeaponFactoryStandard();
            //GameFactory.Instance().EntityFactory = new EntityFactoryStandard();
            GameFactory.Instance().CharacterFactory = new CharacterFactoryStandard();
            GameFactory.Instance().CritterFactory = new CritterFactoryStandard();

            Game aGame = new Game();
            aGame.Run(4);

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
