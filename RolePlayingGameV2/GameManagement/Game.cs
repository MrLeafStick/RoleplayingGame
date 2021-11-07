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
                else 
                {
                    return;
                }
            }
        }

        private bool IsFighting(Character aChar, IParticipant opponent) 
        {
            while (opponent.IsDead == false && aChar.IsDead == false)
            {
                //TODO add some string output to show that some form of combat has happenend...
                opponent.ReceiveDamage(aChar.DealDamage(),aChar.Name);
                if (opponent.IsDead == false)
                {
                    aChar.ReceiveDamage(opponent.DealDamage(),opponent.Name);
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.WriteLine();
            }

            //TODO Return aChar.IsDead
            return opponent.IsDead;
        }

        private void Loot(Character aChar, IParticipant opponent) 
        {
            aChar.GoldOwned += opponent.GoldOwned;
            opponent.GoldOwned = 0;

            foreach (var armor in opponent.ArmorOwned)
            {
                aChar.AddArmor(armor);
            }
            foreach (var weapon in opponent.WeaponsOwned)
            {
                aChar.AddWeapon(weapon);
            }

            opponent.ClearItems();
        }

        private void PrintParticipants(List<IParticipant> participants) 
        {
            foreach (var participant in participants)
            {
                Console.WriteLine(participant);
            }

            Console.Write(new string('*', 17));
            Console.Write("Combat");
            Console.WriteLine(new string('*', 17));
            Console.WriteLine();
        }

        private void PrintStartInfo(Character aChar, List<IParticipant> participants) 
        {
            Console.WriteLine("The game is starting\n");

            Console.Write(new string('*', 18));
            Console.Write("Hero");
            Console.WriteLine(new string('*', 18));
            Console.WriteLine();

            Console.WriteLine(aChar);

            Console.Write(new string('*', 16));
            Console.Write("Opponent");
            Console.WriteLine(new string('*', 16));
            Console.WriteLine();

            PrintParticipants(participants);
        }

        private void PrintEndInfo(Character aChar) 
        {
            Console.Write(new string('*',16));
            Console.Write("Summary");
            Console.WriteLine(new string('*', 16));
            Console.WriteLine();

            Console.WriteLine(aChar);
            Console.WriteLine(new string('*', 40));
        }
    }
}
