using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Participants;
using RoleplayingGameV2.Participants.Creatures;
using RoleplayingGameV2.Participants.Humanoids;
using System;
using System.Collections.Generic;

namespace RoleplayingGameV2.GameManagement
{
    public class Game
    {
        public void Run(int numberOfOpponents)
        {
            var character = new Character("Sigrid");
            var participants = CreateParticipants(numberOfOpponents);

            PrintStartInfo(character, participants);
            FightParticipants(character, participants);
            PrintEndInfo(character);
        }

        private List<IParticipant> CreateParticipants(int numberOfOpponents)
        {
            var participants = new List<IParticipant>();
            for (int i = 0; i < numberOfOpponents; i++)
            {
                participants.Add(GameFactory.Instance.ParticipantFactory.CreateParticipant());
            }
            return participants;
        }

        private void FightParticipants(Character character, List<IParticipant> participants)
        {
            foreach (var participant in participants)
            {
                if(IsFighting(character, participant))
                {
                    Loot(character, participant);
                }
            }
        }

        private bool IsFighting(Character character, IParticipant opponent)
        {
            while (!opponent.IsDead && !character.IsDead)
            {
                opponent.ReceiveDamage(character.DealDamage());
                if(!opponent.IsDead)
                {
                    character.ReceiveDamage(opponent.DealDamage());
                }
            }

            // TODO: return character.IsDead!!!!!!!!!!!!!!
            return opponent.IsDead;
        }

        private void Loot(Character character, IParticipant opponent)
        {
            character.GoldOwned += opponent.GoldOwned;
            opponent.GoldOwned = 0;
            foreach (var armor in opponent.ArmorOwned)
            {
                character.AddArmor(armor);
            }
            foreach (var weapon in opponent.WeaponsOwned)
            {
                character.AddWeapon(weapon);
            }
            opponent.ClearItems();
        }

        private void PrintParticipant(List<IParticipant> participants)
        {
            foreach (var participant in participants)
            {
                Console.WriteLine(participant);
            }
            Console.WriteLine();
        }

        private void PrintStartInfo(Character character, List<IParticipant> participants)
        {
            Console.WriteLine("The game is starting");
            Console.WriteLine(character);
            Console.WriteLine();
            PrintParticipant(participants);
        }

        private void PrintEndInfo(Character character)
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The game has ended!");
            Console.WriteLine(character);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();
        }
    }
}
