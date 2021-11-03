using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_V2.Participants
{
    public abstract class ParticipantBase : IParticipant
    {
        #region Instance Fields
        private int _maxInitialHealthPoints;
        private int _maxInitialGold;
        private int _maxInitialItems;
        private double _maxDamage;
        #endregion

        #region Properties
        public virtual string Name { get;}
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IItem> ItemsOwned { get; set; }
        public bool MyProperty { get; set; }
        public bool IsDead { get { return HealthPoints <= 0; } }
        #endregion

        #region Virtual Methods
        protected virtual double SetInitialHealthPoints()
        {
            return RNG.RandomDouble(1.0, _maxInitialHealthPoints);
        }

        protected virtual int SetInitialGoldOwned()
        {
            return RNG.RandomInt(0, _maxInitialGold);
        }

        public virtual List<IItem> SetInitialItemsOwned()
        {
            List<IItem> initialItems = new List<IItem>();

            for(int i = 0; i < RNG.RandomInt(1, _maxInitialItems); i++)
            {
                initialItems.Add(GetInitialItem());
            }
            return initialItems;
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

        public virtual IItem GetInitialItem()
        {
            int index = RNG.RandomInt(1, 7);

            return null; // TODO: add weapons
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string desc = $"{Name} has {GoldOwned} gold, and is at {HealthPoints:F1} health points\n " +
                $"{Name} owns {ItemsOwned.Count} items:\n";

            foreach(var item in ItemsOwned)
            {
                desc += $"{item}\n";
            }

            return desc;
        }
        #endregion

    }
}
