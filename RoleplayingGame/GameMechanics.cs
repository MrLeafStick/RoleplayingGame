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
            redTeam.AddCharacter(new Damager("Freja", 600, 60, 80));
            redTeam.AddCharacter(new Damager("Thorbjorn", 484, 8, 12));
            redTeam.AddCharacter(new Damager("Svend", 200, 12, 60));
            redTeam.AddCharacter(new Damager("Torben", 350, 20, 40));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Damager("Sindy", 345, 10, 12));
            greenTeam.AddCharacter(new Damager("Eric", 290, 20, 30));
            greenTeam.AddCharacter(new Damager("Stan", 310, 30, 40));
            greenTeam.AddCharacter(new Damager("Kenny", 100, 100, 140));

            BattleArena.DoBattle(redTeam, greenTeam);

        }
    }
}
