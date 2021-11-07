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
            Entity aChar = new Entity("Sigrid", EntityCategory.Living, EntitySpecies.Human, EntityOccupation.Warrior);

            List<IEntity> participants = CreateParticipants(numOpponents);

            PrintStartInfo(aChar, participants);
            FightParticipants(aChar, participants);
            PrintEndInfo(aChar, participants);
        }

        private List<IEntity> CreateParticipants(int numOpponents)
        {
            List<IEntity> participants = new List<IEntity>();

            for (int i = 0; i < numOpponents; i++)
            {
                participants.Add(GameFactory.Instance().ParticipantFactory.CreateParticipant());
            }

            return participants;
        }

        private void FightParticipants(Entity aChar, List<IEntity> participants)
        {
            foreach (var participant in participants)
            {
                if (IsFighting(aChar, participant))
                {
                    Loot(aChar, participant);
                }
            }
        }

        private bool IsFighting(Entity aChar, IEntity opponent)
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

        private void Loot(Entity aChar, IEntity opponent)
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

        private void PrintParticipants(List<IEntity> participants)
        {
            foreach (var participant in participants)
            {
                Console.WriteLine(participant);
            }
            Console.WriteLine();
        }

        private void PrintStartInfo(Entity aChar, List<IEntity> participants)
        {

            int combinations = EntityCategory.List().Count * EntitySpecies.List().Count * EntityOccupation.List().Count;

            Console.WriteLine($"Total number of entity combinations: {combinations}\n");

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The game is about to begin...");
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Characters:\n");
            Console.WriteLine(aChar);

            Console.WriteLine("Enemies:\n");
            PrintParticipants(participants);
        }

        private void PrintEndInfo(Entity aChar, List<IEntity> participants)
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

            foreach (var participant in participants)
            {
                if (!participant.IsDestroyed)
                {
                    Console.WriteLine($"{participant.Name} survived.\n");
                    Console.WriteLine(participant);
                }
                else
                {
                    //string fullName = participant.Name == participant.GetType().Name ? participant.Name : participant.Name + " the " + participant.GetType().Name;

                    Console.WriteLine($"{participant.Name} has died.\n");
                }
            }


        }
    }
}
