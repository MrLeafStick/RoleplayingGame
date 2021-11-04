using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;
using RoleplayingGameV2.Items.Armor;
using RoleplayingGameV2.Items.Weapons;
using System;
using System.Collections.Generic;

namespace RoleplayingGameV2.Participants
{
    public abstract class ParticipantBase : IParticipant
    {
        #region Instance fields
        private int _maxInitialHealthPoints;
        private int _maxInitialGold;
        private int _maxInitialItems;
        private double _maxDamage;
        #endregion

        #region Constructors
        protected ParticipantBase(
            int maxInitialHealthPoints, 
            int maxInitialGold, 
            int maxInitialItems, 
            double maxDamage, 
            string name)
        {
            _maxInitialHealthPoints = maxInitialHealthPoints;
            _maxInitialGold = maxInitialGold;
            _maxInitialItems = maxInitialItems;
            _maxDamage = maxDamage;
            Name = name;

            HealthPoints = SetInitialHealthPoints();
            GoldOwned = SetInitialGoldOwned();
            ItemsOwned = SetInitialItemsOwned();
        }
        #endregion

        #region Properties
        public virtual string Name { get; private set; }
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IItem> ItemsOwned { get; }
        public bool IsDead { get { return HealthPoints <= 0; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            string description = $"{Name} has {GoldOwned} gold, and is at {HealthPoints:F1} Health points\n" +
                $"{Name} ownes {ItemsOwned.Count} items:\n";
            foreach (var item in ItemsOwned)
            {
                description += $"{item.Description}\n";
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

        protected virtual List<IItem> SetInitialItemsOwned()
        {
            List<IItem> initialItems = new List<IItem>();
            var initialItemsAmount = RNG.RandomInt(0, _maxInitialItems);
            for (int i = 0; i < initialItemsAmount; i++)
            {
                initialItems.Add(GetInitialItem());
            }
            return initialItems;
        }

        public virtual IItem GetInitialItem()
        {
            int index = RNG.RandomInt(1, 8);
            switch (index)
            {
                case 1: return new ClothGloves();
                case 2: return new LeatherBoots();
                case 3: return new PlateBoots();
                case 4: return new WoodenShield();
                case 5: return new IronSword();
                case 6: return new SteelLance();
                case 7: return new WoodenMace();
                case 8: return new WoodenStick();
                default: throw new Exception($"Could not generate item with index {index}");
            }
        }

        public virtual double DealDamage()
        {
            return RNG.RandomDouble(0.0, _maxDamage);
        }

        public virtual void ReceiveDamage(double damagePoints)
        {
            HealthPoints -= damagePoints;
        }

        public virtual void AddItem(IItem item)
        {
            ItemsOwned.Add(item);
        }

        public virtual void ClearItems()
        {
            ItemsOwned.Clear();
        }
        #endregion
    }
}
