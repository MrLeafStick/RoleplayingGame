using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayingGame
{
    public class GameMechanics
    {
        public static void GameLogic()
        {
            CharacterGroup redTeam = new CharacterGroup("Team Red");
            redTeam.AddCharacter(new Defender("Freja", 600, 60, 80));
            redTeam.AddCharacter(new Defender("Thorbjorn", 484, 8, 12));
            redTeam.AddCharacter(new Damager("Svend", 200, 12, 60));
            redTeam.AddCharacter(new Damager("Torben", 350, 20, 40));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Defender("Sindy", 345, 10, 12));
            greenTeam.AddCharacter(new Defender("Eric", 290, 20, 30));
            greenTeam.AddCharacter(new Damager("Stan", 310, 30, 40));
            greenTeam.AddCharacter(new Damager("Kenny", 100, 100, 140));

            BattleArena.DoBattle(redTeam, greenTeam);

        }
    }
}
