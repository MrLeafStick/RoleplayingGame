using RPG_V2.Interfaces;
using RPG_V2.Participants;
using RPG_V2.Participants.Creatures;
using RPG_V2.Participants.Humanoids;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2
{
    public class Game
    {
        public void Run()
        {
            Character aChar = new Character("Sigrid");

            List<IParticipant> participants = CreateParticipants();

            PrintStartInfo(aChar, participants);
            FightParticipants(aChar, participants);
            PrintEndInfo(aChar);
        }

        private List<IParticipant> CreateParticipants()
        {
            List<IParticipant> participants = new List<IParticipant>();

            participants.Add(new Bear());
            participants.Add(new Troll("Vectur"));
            participants.Add(new Snake());

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
            aChar.GoldOwned = aChar.GoldOwned + opponent.GoldOwned;
            opponent.GoldOwned = 0;

            foreach(var item in opponent.ItemsOwned)
            {
                aChar.AddItem(item);
            }

            opponent.ItemsOwned.Clear(); //TODO use clearitems
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
