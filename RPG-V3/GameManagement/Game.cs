using RPG_V3.Entities;
using RPG_V3.Interfaces;
using RPG_V3.Interfaces.Items;
using RPG_V3.Items;
using System;
using System.Collections.Generic;

namespace RPG_V3.GameManagement
{
    public class Game
    {
        public void Run(int numOpponents)
        {
            Character aChar = new Character("Sigrid", EntityCategory.Living, EntitySpecies.Human, EntityOccupation.Warrior);

            List<ICharacter> entities = CreateEntities(numOpponents);

            entities.Add(new Character("SuperMoose", EntityCategory.Clockwork, EntitySpecies.Moose, EntityOccupation.Blacksmith));

            PrintStartInfo(aChar, entities);
            FightEntities(aChar, entities);
            PrintEndInfo(aChar, entities);
        }

        private List<ICharacter> CreateEntities(int numOpponents)
        {
            List<ICharacter> entities = new List<ICharacter>();

            for (int i = 0; i < numOpponents; i++)
            {
                entities.Add(GameFactory.Instance().CharacterFactory.CreateCharacter());
            }

            return entities;
        }

        private void FightEntities(Character aChar, List<ICharacter> entities)
        {
            foreach (var entity in entities)
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
            // Copy opponent stuff
            aChar.GoldOwned += opponent.GoldOwned;

            foreach (var armor in opponent.ArmorOwned)
            {
                aChar.AddArmor(armor);
            }

            foreach (var weapon in opponent.WeaponsOwned)
            {
                aChar.AddWeapons(weapon);
            }

            // Clear opponent stuff
            opponent.GoldOwned = 0;
            opponent.ArmorOwned.Clear();
            opponent.WeaponsOwned.Clear();
        }

        private void PrintEntities(List<ICharacter> entities)
        {
            foreach (var entity in entities)
            {
                Console.WriteLine(entity);
            }
            Console.WriteLine();
        }

        private void PrintStartInfo(Character aChar, List<ICharacter> entities)
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
            PrintEntities(entities);
        }

        private void PrintEndInfo(Character aChar, List<ICharacter> entities)
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

            foreach (var entity in entities)
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
