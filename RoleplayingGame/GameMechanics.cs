﻿using System;
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
            redTeam.AddCharacter(new Damager("Freja", 600, 60, 80, 100, 10, 0, 0));
            redTeam.AddCharacter(new Defender("Thorbjorn", 484, 8, 12, 100, 1, 0, 0));
            redTeam.AddCharacter(new BaseCharacter("Svend", 200, 12, 60, 100, 2, 0, 0));
            redTeam.AddCharacter(new Wizard("Merlin", 100, 20, 40, 100, 5, 500, 5));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Defender("Sindy", 345, 10, 12, 100, 10, 0, 0));
            greenTeam.AddCharacter(new BaseCharacter("Eric", 290, 20, 30, 100, 5, 0, 0));
            greenTeam.AddCharacter(new Damager("Kenny", 100, 100, 140, 100, 1, 0, 0));
            greenTeam.AddCharacter(new Wizard("Gandalf", 100, 50, 140, 100, 1, 500, 2));

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
