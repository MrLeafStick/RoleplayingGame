using RpgV2.Interfaces;
using RpgV2.Participants;
using RpgV2.Participants.Creatures;
using RpgV2.Participants.Humanoids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.GameMangement
{
    public class Game
    {
        public void Run(int numOfOpponents)
        {
            var aChar = new Character("Sigrid");
            List<IParticipant> participants = CreateParticipants(numOfOpponents);

            PrintStartInfo(aChar, participants);
            FightParticipants(aChar, participants);
            PrintEndInfo(aChar);
        }

        private List<IParticipant> CreateParticipants(int numOfOpponents)
        {
            var participants = new List<IParticipant>();
            for (int i = 0; i < numOfOpponents; i++)
            {
                participants.Add(GameFactory.Instance().ParticipantFactory.CreateParticipant());
            }
            return participants;
        }

        private void FightParticipants(Character aChar,List<IParticipant> participants)
        {
            foreach(var participant in participants)
            {
                if (IsFighting(aChar,participant))
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
            return opponent.IsDead;
        }
        private void Loot(Character aChar,IParticipant opponent)
        {
            aChar.GoldOwned += opponent.GoldOwned;
            opponent.GoldOwned = 0;
            foreach (var item in opponent.ArmorOwned)
            {
                aChar.AddArmor(item);
            }
            foreach (var item in opponent.WeaponsOwned)
            {
                aChar.AddWeapon(item);
            }
            
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
            if (aChar.IsDead)
            {
                Console.WriteLine($"{aChar.Name} has died - ripperino in pepperino :(");
            }
            else
            {
                Console.WriteLine($"{aChar.Name} has defeated the evil foes - good job!");
                Console.WriteLine();
                Console.WriteLine(aChar);
            }
            Console.WriteLine(new string('*',40));
        }
    }
}
