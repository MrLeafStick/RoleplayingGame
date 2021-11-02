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
            redTeam.AddCharacter(new Defender("Thorbjorn", 484, 100, 8, 12));
            redTeam.AddCharacter(new BaseCharacter("Svend", 200, 100, 12, 60));
            redTeam.AddCharacter(new Damager("Torben", 350, 100, 20, 40));
            redTeam.AddCharacter(new Sorceress("Freja", 600, 100,20, 40));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Sorceress("Sindy", 345, 100, 10, 12));
            greenTeam.AddCharacter(new BaseCharacter("Eric", 290, 100, 20, 30));
            greenTeam.AddCharacter(new Defender("Stan", 310, 100, 30, 40));
            greenTeam.AddCharacter(new Damager("Kenny", 100, 100,40, 41));


            BattleArena.DoBattle(redTeam, greenTeam);
        }
    }
}
