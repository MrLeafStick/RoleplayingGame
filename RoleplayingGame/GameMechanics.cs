using System.Collections.Generic;

namespace RoleplayingGame
{
    public class GameMechanics
    {
        public void GameLogic()
        {
            var wizardSet = new Dictionary<AbilityType, double>() {{AbilityType.BasicAttack, 10},{AbilityType.Blizzard, 35},{ AbilityType.Fireball, 50}};
            var defenderSet = new Dictionary<AbilityType, double>() { {AbilityType.BasicAttack, 15},{AbilityType.ShieldBlock, 0},{AbilityType.ShieldSmash, 25} };
            var damagerSet = new Dictionary<AbilityType, double>() { { AbilityType.BasicAttack, 20 }, { AbilityType.PowerAttack, 50 }, { AbilityType.WhirlwindAttack, 25 } };
            var clericSet = new Dictionary<AbilityType, double>() { { AbilityType.BasicAttack, 5 }, { AbilityType.SacredGround, 5 }, { AbilityType.HealingSpring, 0 } };

            BaseCharacterGroup redTeam = new BaseCharacterGroup("Team Red");
            redTeam.AddBaseCharacter(new Wizard("Freja", wizardSet, 600, 60, 80));
            redTeam.AddBaseCharacter(new Defender("Thorbjorn", defenderSet, 484, 8, 12));
            redTeam.AddBaseCharacter(new Damager("Svend", damagerSet, 200, 12, 60));
            redTeam.AddBaseCharacter(new Cleric("Torben", clericSet, 350, 20, 40));

            BaseCharacterGroup greenTeam = new BaseCharacterGroup("Team Green");
            greenTeam.AddBaseCharacter(new Cleric("Sindy", clericSet, 345, 10, 12));
            greenTeam.AddBaseCharacter(new Defender("Eric", clericSet, 290, 20, 30));
            greenTeam.AddBaseCharacter(new Damager("Stan", damagerSet, 310, 30, 40));
            greenTeam.AddBaseCharacter(new Wizard("Kenny", wizardSet, 100, 100, 140));

            BattleArena.DoBattle(redTeam, greenTeam);
        }
    }
}
