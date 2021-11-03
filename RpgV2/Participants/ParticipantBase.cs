using RpgV2.Helpers;
using RpgV2.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgV2.Participants
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
        public virtual string Name { get; }
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IItem> ItemsOwned { get; }

        public bool IsDead
        {
            get { return HealthPoints <= 0; }
        }
        #endregion

        #region virtual Methods
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
            for (int i = 0; i < RNG.RandomInt(1, _maxInitialItems); i++)
            {
                initialItems.Add(GetInitialItem());
            }
            return initialItems;
        }

        public virtual IItem GetInitialItem()
        {
            int index = RNG.RandomInt(1, 7);

            return null; //TODO add weapons
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

        #region Methods
        public override string ToString()
        {
            string desc = $"{Name} has {GoldOwned} gold, and is at {HealthPoints:F1} health points\n " +
                $"{Name} ownes {ItemsOwned.Count} items:\n";

            foreach (var item in ItemsOwned)
            {
                desc += $"{item}\n";
            }

            return desc;
        }


        #endregion
    }
}
