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
            redTeam.AddCharacter(new Defender("Thorbjorn", 484, 8, 12));
            redTeam.AddCharacter(new Character("Svend", 200, 12, 60));
            redTeam.AddCharacter(new Character("Torben", 350, 20, 40));
            redTeam.AddCharacter(new Damager("Freja", 600, 60, 80));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Defender("Sindy", 345, 10, 12));
            greenTeam.AddCharacter(new Character("Eric", 290, 20, 30));
            greenTeam.AddCharacter(new Character("Stan", 310, 30, 40));
            greenTeam.AddCharacter(new Damager("Kenny", 100, 100, 140));

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
