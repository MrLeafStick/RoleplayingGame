using System.Collections.Generic;

namespace RoleplayingGame
{
    public class GameMechanics
    {
        public void GameLogic()
        {
            CharacterGroup redTeam = new CharacterGroup("Team Red");
            redTeam.AddCharacter(new Damager("Freja", 600, 60, 80));
            redTeam.AddCharacter(new Wizard("Dumbledore", 484, 8, 12));
            redTeam.AddCharacter(new Character("Svend", 200, 12, 60));
            redTeam.AddCharacter(new Defender("Torben", 350, 20, 40));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Damager("Sindy", 345, 10, 12));
            greenTeam.AddCharacter(new Character("Eric", 290, 20, 30));
            greenTeam.AddCharacter(new Wizard("Voldemort", 310, 30, 40));
            greenTeam.AddCharacter(new Defender("Kenny", 320, 40, 41));

            BattleArena.DoBattle(redTeam, greenTeam);
        }
    }
}
