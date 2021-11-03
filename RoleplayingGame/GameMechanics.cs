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
            CharacterGroup redTeam = new CharacterGroup("Team Red", ConsoleColor.Red);

            BaseCharacter c1 = new Damager("Freja", 600, 60, 80, 100, 20, 0, 0);
            BaseCharacter c2 = new Defender("Thorbjorn", 484, 8, 12, 100, 15, 0, 0);
            BaseCharacter c3 = new BaseCharacter("Svend", 200, 12, 60, 100, 10, 0, 0);
            BaseCharacter c4 = new Wizard("Merlin", 100, 20, 40, 100, 30, 500, 5);

            c1.AddAbility(AbilityType.Crossbow, 50);
            c1.AddAbility(AbilityType.Knife, 10);

            c2.AddAbility(AbilityType.Longbow, 30);
            c2.AddAbility(AbilityType.Knife, 5);

            c3.AddAbility(AbilityType.Broadsword, 40);
            c3.AddAbility(AbilityType.Knife, 7);

            c4.AddAbility(AbilityType.LavaBall, 60);
            c4.AddAbility(AbilityType.ThunderBolt, 50);
            c4.AddAbility(AbilityType.Tornado, 40);
            c4.AddAbility(AbilityType.FleshRot, 30);

            redTeam.AddCharacter(c1);
            redTeam.AddCharacter(c2);
            redTeam.AddCharacter(c3);
            redTeam.AddCharacter(c4);

            CharacterGroup greenTeam = new CharacterGroup("Team Green", ConsoleColor.Green);

            BaseCharacter r1 = new Defender("Sindy", 500, 10, 12, 100, 10, 0, 0);
            BaseCharacter r2 = new BaseCharacter("Eric", 290, 20, 30, 100, 15, 0, 0);
            BaseCharacter r3 = new Damager("Kenny", 400, 100, 140, 100, 1, 20, 0);
            BaseCharacter r4 = new Wizard("Gandalf", 100, 50, 140, 100, 35, 500, 2);

            r1.AddAbility(AbilityType.Crossbow, 30);
            r1.AddAbility(AbilityType.Knife, 5);

            r2.AddAbility(AbilityType.Crossbow, 40);
            r2.AddAbility(AbilityType.Knife, 10);

            r3.AddAbility(AbilityType.Crossbow, 50);
            r3.AddAbility(AbilityType.Knife, 20);

            r4.AddAbility(AbilityType.AcidRain, 60);
            r4.AddAbility(AbilityType.Armageddon, 50);
            r4.AddAbility(AbilityType.FireBall, 40);
            r4.AddAbility(AbilityType.IceStorm, 30);

            greenTeam.AddCharacter(r1);
            greenTeam.AddCharacter(r2);
            greenTeam.AddCharacter(r3);
            greenTeam.AddCharacter(r4);

            BattleArena.DoBattle(redTeam, greenTeam);
        }
    }
}
