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
            var basicAttack = new Ability("Basic attack", AbilityType.Weapon, 5, 5, 5);
            var fireball = new Ability("Fireball", AbilityType.Weapon, 10, 5, 15);

            CharacterGroup redTeam = new CharacterGroup("Team Red");
            redTeam.AddCharacter(new Wizard("Freja", new List<Ability>(){ basicAttack, fireball }, 600, 60, 80));
            redTeam.AddCharacter(new Defender("Thorbjorn", new List<Ability>() { basicAttack}, 484, 8, 12));
            redTeam.AddCharacter(new Damager("Svend", new List<Ability>() { basicAttack }, 200, 12, 60));
            redTeam.AddCharacter(new Damager("Torben", new List<Ability>() { basicAttack }, 350, 20, 40));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Defender("Sindy", new List<Ability>() { basicAttack }, 345, 10, 12));
            greenTeam.AddCharacter(new Defender("Eric", new List<Ability>() { basicAttack }, 290, 20, 30));
            greenTeam.AddCharacter(new Damager("Stan", new List<Ability>() { basicAttack }, 310, 30, 40));
            greenTeam.AddCharacter(new Wizard("Kenny", new List<Ability>() { basicAttack, fireball }, 100, 100, 140));

            BattleArena.DoBattle(redTeam, greenTeam);

        }
    }
}
