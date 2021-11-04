using RolePlayingGameV2.Interfaces;
using RolePlayingGameV2.Participants;
using RolePlayingGameV2.Participants.Creatures;
using RolePlayingGameV2.Participants.Humanoids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGameV2.GameManagement
{
    public class Game
    {
        public void Run(int noOfOpponents) 
        {
            var aChar = new Character("Sigrid");
            List<IParticipant> participants = CreateParticipants(noOfOpponents);

            PrintStartInfo(aChar, participants);
            FightParticipants(aChar, participants);
            PrintEndInfo(aChar);
        }

        private List<IParticipant> CreateParticipants(int noOfOpponents)
        {
            var participants = new List<IParticipant>();

            for (int i = 0; i < noOfOpponents; i++)
            {
                participants.Add(GameFactory.Instance().participantFactory.CreateParticipant());
            }

            return participants;
        }

        private void FightParticipants(Character aChar, List<IParticipant> participants) 
        {
            foreach (var participant in participants)
            {
                if (IsFighting(aChar, participant))
                {
                    Loot(aChar, participant);
                }
            }
        }

        private bool IsFighting(Character aChar, IParticipant opponent) 
        {
            while (opponent.IsDead == false && aChar.IsDead == false)
            {
                opponent.ReceiveDamage(aChar.DealDamage());
                if (opponent.IsDead == false)
                {
                    aChar.ReceiveDamage(opponent.DealDamage());
                }
            }

            //TODO Return aChar.IsDead
            return opponent.IsDead;
        }

        private void Loot(Character aChar, IParticipant opponent) 
        {
            aChar.GoldOwned += opponent.GoldOwned;
            opponent.GoldOwned = 0;

            foreach (var item in opponent.ItemsOwned)
            {
                aChar.ItemsOwned.Add(item);
            }

            opponent.ItemsOwned.Clear();
        }

        private void PrintParticipants(List<IParticipant> participants) 
        {
            foreach (var participant in participants)
            {
                Console.WriteLine(participant);
            }
            Console.WriteLine();
        }

        private void PrintStartInfo(Character aChar, List<IParticipant> participants) 
        {
            Console.WriteLine("The game is starting");
            Console.WriteLine(aChar);
            Console.WriteLine();
            PrintParticipants(participants);

        }

        private void PrintEndInfo(Character aChar) 
        {
            Console.WriteLine(new string('*',40));
            Console.WriteLine("The game has ended");
            Console.WriteLine(aChar);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();
        }
    }
}
