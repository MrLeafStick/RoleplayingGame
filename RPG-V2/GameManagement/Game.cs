using RPG_V2.Interfaces;
using RPG_V2.Participants;
using RPG_V2.Participants.Creatures;
using RPG_V2.Participants.Humanoids;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.GameManagement
{
    public class Game
    {
        public void Run(int numOpponents)
        {
            Character aChar = new Character("Sigrid");

            List<IParticipant> participants = CreateParticipants(numOpponents);

            PrintStartInfo(aChar, participants);
            FightParticipants(aChar, participants);
            PrintEndInfo(aChar);
        }

        private List<IParticipant> CreateParticipants(int numOpponents)
        {
            List<IParticipant> participants = new List<IParticipant>();

            for (int i = 0; i < numOpponents; i++)
            {
                participants.Add(GameFactory.Instance().ParticipantFactory.CreateParticipant());
            }

            return participants;
        }

        private void FightParticipants(Character aChar, List<IParticipant> participants)
        {
            foreach(var participant in participants)
            {
                if(IsFighting(aChar, participant))
                {
                    Loot(aChar, participant);
                }
            }
        }

        private bool IsFighting(Character aChar, IParticipant opponent)
        {
            while(!opponent.IsDead && !aChar.IsDead)
            {
                opponent.ReceiveDamage(aChar.DealDamage());

                if(!opponent.IsDead)
                {
                    aChar.ReceiveDamage(opponent.DealDamage());
                }
            }

            // TODO return aChar dead
            return opponent.IsDead;
        }

        private void Loot(Character aChar, IParticipant opponent)
        {
            aChar.GoldOwned += opponent.GoldOwned;

            foreach(var armor in opponent.ArmorOwned)
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

        private void PrintParticipants(List<IParticipant> participants)
        {
            foreach(var participant in participants)
            {
                Console.WriteLine(participant);
            }
            Console.WriteLine();
        }

        private void PrintStartInfo(Character aChar, List<IParticipant> participants)
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The game is starting");
            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Characters:");
            Console.WriteLine(aChar);

            Console.WriteLine("Enemies:");
            PrintParticipants(participants);
        }

        private void PrintEndInfo(Character aChar)
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The game has ended");
            Console.WriteLine(new string('*', 40));

            Console.WriteLine(aChar);
        }

    }
}
