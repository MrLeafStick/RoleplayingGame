using RoleplayingGameV2.Helpers;
using RoleplayingGameV2.Interfaces;
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
            int index = RNG.RandomInt(0, 7);
            return null; // TODO: Fix!
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
