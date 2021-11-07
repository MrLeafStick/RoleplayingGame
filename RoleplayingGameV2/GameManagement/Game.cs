using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Participants;
using RoleplayingGameV2.Participants.Creatures;
using RoleplayingGameV2.Participants.Humanoids;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RoleplayingGameV2.GameManagement
{
    public class Game
    {
        private readonly Action<object> _outputProvider;

        public Game(Action<object> outputProvider)
        {
            _outputProvider = outputProvider;
        }

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
                    var damageFromOpponent = opponent.DealDamage();
                    character.ReceiveDamage(damageFromOpponent);

                    if (character.IsDead)
                    {
                        _outputProvider($"{character.Name} was killed by {opponent.Name}, with a hit of {damageFromOpponent:F1} health points.");
                        _outputProvider($"{character.Name} is now dead with {character.HealthPoints:F1} health points.");
                        return false;
                    }
                }
            }

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
                _outputProvider(participant);
            }
            _outputProvider("");
        }

        private void PrintStartInfo(Character character, List<IParticipant> participants)
        {
            _outputProvider("The game is starting");
            _outputProvider(character);
            _outputProvider("");
            PrintParticipant(participants);
        }

        private void PrintEndInfo(Character character)
        {
            _outputProvider(new string('*', 40));
            _outputProvider("The game has ended!");
            _outputProvider(character);
            _outputProvider(new string('*', 40));
            _outputProvider("");
        }
    }
}
