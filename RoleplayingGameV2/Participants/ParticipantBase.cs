using RoleplayingGameV2.GameManagement;
using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Items.Armor;
using RoleplayingGameV2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RoleplayingGameV2.Participants
{
    public abstract class ParticipantBase : IParticipant
    {
        #region Instance fields
        private int _maxInitialHealthPoints;
        private int _maxInitialGold;
        private int _maxInitialArmor;
        private int _maxInitialWeapons;
        private double _meleeMaxDamage;
        #endregion

        #region Constructors
        protected ParticipantBase(
            int maxInitialHealthPoints, 
            int maxInitialGold, 
            int maxInitialArmor, 
            int maxInitialWeapons, 
            double meleeMaxDamage, 
            string name)
        {
            _maxInitialHealthPoints = maxInitialHealthPoints;
            _maxInitialGold = maxInitialGold;
            _maxInitialArmor = maxInitialArmor;
            _maxInitialWeapons = maxInitialWeapons;
            _meleeMaxDamage = meleeMaxDamage;
            Name = name;

            HealthPoints = SetInitialHealthPoints();
            GoldOwned = SetInitialGoldOwned();
            ArmorOwned = SetInitialArmorOwned();
            WeaponsOwned = SetInitialWeaponsOwned();
        }
        #endregion

        #region Properties
        public virtual string Name { get; private set; }
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }
        public bool IsDead { get { return HealthPoints <= 0; } }
        public double ArmorPoints { get { return ArmorOwned.Count == 0 ? 0 : ArmorOwned.Select(a => a.ArmorPoints).Sum(); } }
        #endregion

        #region Methods
        public override string ToString()
        {
            string description = $"{Name} has {GoldOwned} gold, and is at {HealthPoints:F1} Health points\n" +
                $"{Name} and has {ArmorPoints:F1} armor points\n";
            description += $"{Name} owns {ArmorOwned.Count} armor items:\n";
            foreach (var armor in ArmorOwned)
            {
                description += $"{armor}\n";
            }
            description += $"{Name} owns {WeaponsOwned.Count} weapon items:\n";
            foreach (var weapon in WeaponsOwned)
            {
                description += $"{weapon}\n";
            }
            return description;
        }
        #endregion

        #region Virtual Methods
        protected virtual double SetInitialHealthPoints()
        {
            return RNG.RandomDouble(1.0f, _maxInitialHealthPoints);
        }

        protected virtual int SetInitialGoldOwned()
        {
            return RNG.RandomInt(0, _maxInitialGold);
        }

        protected List<IWeapon> SetInitialWeaponsOwned()
        {
            var initialWeapons = new List<IWeapon>();
            for (int i = 0; i < _maxInitialWeapons; i++)
            {
                initialWeapons.Add(GameFactory.Instance.WeaponFactory.CreateWeapon());
            }
            return initialWeapons;
        }

        protected List<IArmor> SetInitialArmorOwned()
        {
            var initialArmor = new List<IArmor>();
            for (int i = 0; i < _maxInitialArmor; i++)
            {
                initialArmor.Add(GameFactory.Instance.ArmorFactory.CreateArmor());
            }
            return initialArmor;
        }

        public virtual double DealDamage()
        {
            return WeaponsOwned.Count == 0 ? 0.0 : WeaponsOwned.Select(weapon => weapon.WeaponDamage).Max();
        }

        public virtual void ReceiveDamage(double damagePoints)
        {
            HealthPoints -= damagePoints;
        }

        public virtual void AddWeapon(IWeapon weapon)
        {
            WeaponsOwned.Add(weapon);
        }

        public virtual void AddArmor(IArmor armor)
        {
            ArmorOwned.Add(armor);
        }

        public virtual void ClearItems()
        {
            ArmorOwned.Clear();
            WeaponsOwned.Clear();
        }
        #endregion
    }
}
