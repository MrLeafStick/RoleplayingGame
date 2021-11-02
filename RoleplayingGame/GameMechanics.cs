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
            CharacterGroup redTeam = new CharacterGroup("Team Red");

            BaseCharacter c1 = new Damager("Freja", 600, 60, 80, 100, 10, 0, 0);
            BaseCharacter c2 = new Defender("Thorbjorn", 484, 8, 12, 100, 1, 0, 0);
            BaseCharacter c3 = new BaseCharacter("Svend", 200, 12, 60, 100, 2, 0, 0);
            BaseCharacter c4 = new Wizard("Merlin", 100, 20, 40, 100, 5, 500, 5);

            c1.AddAbility(AbilityType.Crossbow, 42);
            c2.AddAbility(AbilityType.Crossbow, 42);
            c3.AddAbility(AbilityType.Crossbow, 42);
            c4.AddAbility(AbilityType.AcidRain, 42);
            c4.AddAbility(AbilityType.Armageddon, 42);

            redTeam.AddCharacter(c1);
            redTeam.AddCharacter(c2);
            redTeam.AddCharacter(c3);
            redTeam.AddCharacter(c4);

            CharacterGroup greenTeam = new CharacterGroup("Team Green");

            BaseCharacter r1 = new Defender("Sindy", 345, 10, 12, 100, 10, 0, 0);
            BaseCharacter r2 = new BaseCharacter("Eric", 290, 20, 30, 100, 5, 0, 0);
            BaseCharacter r3 = new Damager("Kenny", 100, 100, 140, 100, 1, 0, 0);
            BaseCharacter r4 = new Wizard("Gandalf", 100, 50, 140, 100, 1, 500, 2);

            c1.AddAbility(AbilityType.Crossbow, 42);
            c2.AddAbility(AbilityType.Crossbow, 42);
            c3.AddAbility(AbilityType.Crossbow, 42);
            c4.AddAbility(AbilityType.AcidRain, 42);
            c4.AddAbility(AbilityType.Armageddon, 42);

            greenTeam.AddCharacter(r1);
            greenTeam.AddCharacter(r2);
            greenTeam.AddCharacter(r3);
            greenTeam.AddCharacter(r4);

            BattleArena.DoBattle(redTeam, greenTeam);

            /*
            CharacterGroup redTeam = new CharacterGroup("Team Red");
            redTeam.AddCharacter(new Defender("Freja", 600, 60, 80));
            redTeam.AddCharacter(new Character("Torben", 350, 20, 40));
            redTeam.AddCharacter(new Character("Svend", 200, 12, 60));
            redTeam.AddCharacter(new Damager("Thorbjørn", 350, 20, 40));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Defender("Kenny", 320, 40, 41));
            greenTeam.AddCharacter(new Character("Sindy", 345, 10, 12));
            greenTeam.AddCharacter(new Character("Eric", 290, 20, 30));
            greenTeam.AddCharacter(new Damager("Stan", 320, 30, 140));

            BattleArena.DoBattle(redTeam, greenTeam);
            */

        }
    }
}
