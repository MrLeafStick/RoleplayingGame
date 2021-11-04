using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Participants;
using RoleplayingGameV2.Participants.Creatures;
using RoleplayingGameV2.Participants.Humanoids;
using System;
using System.Collections.Generic;

namespace RoleplayingGameV2
{
    public class Game
    {
        public void Run()
        {
            var character = new Character("Sigrid");
            var participants = CreateParticipants();

            PrintStartInfo(character, participants);
            FightParticipants(character, participants);
            PrintEndInfo(character);
        }

        private List<IParticipant> CreateParticipants()
        {
            var participants = new List<IParticipant>
            {
                new Bear(),
                new Troll("Victor"),
                new Snake()
            };
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
            foreach (var item in opponent.ItemsOwned)
            {
                character.AddItem(item);
            }
            opponent.ItemsOwned.Clear();
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
