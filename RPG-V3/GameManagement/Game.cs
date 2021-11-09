using RPG_V3.Entities;
using RPG_V3.Interfaces;
using System;
using System.Collections.Generic;

namespace RPG_V3.GameManagement
{
    public class Game
    {
        public void Run(int numOpponents)
        {
            Character aChar = new Character("Sigrid", EntityCategory.Living, EntitySpecies.Human, EntityOccupation.Warrior);

            List<ICharacter> opponentCharacters = CreateEntities(numOpponents);
            //List<ICritter> opponentCritters = CreateCritters(numOpponents);

            opponentCharacters.Add(new Character("SuperMoose", EntityCategory.Clockwork, EntitySpecies.Moose, EntityOccupation.Blacksmith));

            PrintStartInfo(aChar, opponentCharacters);
            FightEntities(aChar, opponentCharacters);
            PrintEndInfo(aChar, opponentCharacters);
        }

        private List<ICharacter> CreateEntities(int numOpponents)
        {
            List<ICharacter> opponentCharacters = new List<ICharacter>();

            for (int i = 0; i < numOpponents; i++)
            {
                opponentCharacters.Add(GameFactory.Instance().CharacterFactory.CreateCharacter());
            }

            return opponentCharacters;
        }

        private List<ICritter> CreateCritters(int numOpponents)
        {
            List<ICritter> opponentCritters = new List<ICritter>();

            for (int i = 0; i < numOpponents; i++)
            {
                opponentCritters.Add(GameFactory.Instance().CritterFactory.CreateCritter());
            }

            return opponentCritters;
        }

        private void FightEntities(Character aChar, List<ICharacter> opponentCharacters)
        {
            foreach (var entity in opponentCharacters)
            {
                if (IsFighting(aChar, entity))
                {
                    Loot(aChar, entity);
                }
            }
        }

        private bool IsFighting(Character aChar, ICharacter opponent)
        {
            while (!opponent.IsDestroyed && !aChar.IsDestroyed)
            {
                opponent.ReceiveDamage(aChar.DealDamage());

                if (!opponent.IsDestroyed)
                {
                    aChar.ReceiveDamage(opponent.DealDamage());
                }
            }

            return opponent.IsDestroyed;
        }

        private void Loot(Character aChar, ICharacter opponent)
        {
            aChar.GoldOwned += opponent.GoldOwned;

            foreach (var armor in opponent.ArmorOwned)
            {
                aChar.AddArmor(armor);
            }

            foreach (var weapon in opponent.WeaponsOwned)
            {
                aChar.AddWeapons(weapon);
            }

            opponent.GoldOwned = 0;
            opponent.ArmorOwned.Clear();
            opponent.WeaponsOwned.Clear();
        }

        private void PrintEntities(List<ICharacter> opponentCharacters)
        {
            foreach (var entity in opponentCharacters)
            {
                Console.WriteLine(entity);
            }
            Console.WriteLine();
        }

        private void PrintStartInfo(Character aChar, List<ICharacter> opponentCharacters)
        {

            int combinations = EntityCategory.List().Count * EntitySpecies.List().Count * EntityOccupation.List().Count;

            Console.WriteLine($"Total number of entity combinations: {combinations}\n");

            EntitySpecies.PrintSpecies();

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The game is about to begin...");
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Characters:\n");
            Console.WriteLine(aChar);

            Console.WriteLine("Enemies:\n");
            PrintEntities(opponentCharacters);
        }

        private void PrintEndInfo(Character aChar, List<ICharacter> opponentCharacters)
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The game has ended.");
            Console.WriteLine(new string('*', 40));

            if (!aChar.IsDestroyed)
            {
                Console.WriteLine($"{aChar.Name} survived.\n");
                Console.WriteLine(aChar);
            }
            else
            {
                Console.WriteLine($"{aChar.Name} has died.\n");
            }

            foreach (var entity in opponentCharacters)
            {
                if (!entity.IsDestroyed)
                {
                    Console.WriteLine($"{entity.Name} survived.\n");
                    Console.WriteLine(entity);
                }
                else
                {
                    //string fullName = entity.Name == entity.GetType().Name ? entity.Name : entity.Name + " the " + entity.GetType().Name;

                    Console.WriteLine($"{entity.Name} has died.\n");
                }
            }
        }
    }
}
