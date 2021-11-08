using RoleplayingGameV2.Factories;
using RoleplayingGameV2.GameManagement;
using System;

GameFactory.Instance.ArmorFactory = new ArmorFactoryStandard();
GameFactory.Instance.WeaponFactory = new WeaponFactoryStandard();
GameFactory.Instance.ParticipantFactory = new ParticipantFactoryStandard();

var game = new Game(Console.WriteLine);
game.Run(900);
KeepConsoleWindowOpen();

static void KeepConsoleWindowOpen()
{
    Console.WriteLine();
    Console.WriteLine("Done, press any key to close the console.");
    Console.ReadLine();
}
