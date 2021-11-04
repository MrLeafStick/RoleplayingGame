using RpgV2.Interfaces;
using RpgV2.Participants;
using RpgV2.Participants.Creatures;
using RpgV2.Participants.Humanoids;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.GameManagement
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
                participants.Add(GameFactory.Instance().ParticipantFactory.CreateParticipant());
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
            while(!opponent.IsDead && !aChar.IsDead)
            {
                opponent.ReceiveDamage(aChar.DealDamage());
                if (!opponent.IsDead)
                {
                    aChar.ReceiveDamage(opponent.DealDamage());
                }
            }

            //TODO RETURN CHAR:DEAD
            return opponent.IsDead;
        }

        private void Loot(Character aChar, IParticipant opponent)
        {
            aChar.GoldOwned = aChar.GoldOwned + opponent.GoldOwned;
            opponent.GoldOwned = 0;
            foreach (var item in opponent.ItemsOwned)
            {
                aChar.AddItem(item);
            }
            
        }

        private void PrintParticipants(List<IParticipant> participants)
        {
            foreach (var parcipant in participants)
            {
                Console.WriteLine(parcipant);
            }
            Console.WriteLine();
        }

        private void PrintStartInfo(Character aChar, List<IParticipant> parcipants)
        {
            Console.WriteLine("The gams is starting");
            Console.WriteLine(aChar);
            Console.WriteLine();
            PrintParticipants(parcipants);
        }

        private void PrintEndInfo(Character aChar)
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The game has ended");
            Console.WriteLine(aChar);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();
        }

    }
}
