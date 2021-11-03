using RPGv2.Helpers;
using RPGv2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGv2.Participants
{
    public abstract class ParticipantBase : IParticipants
    {
        private int _maxInitialHealthPoints;
        private int _maxInitialGold;
        private int _maxInitialItems;
        private double _maxDamage;

        #region Properties
        public virtual string Name { get; set; }
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IItems> ItemsOwned { get; }
        public bool isDead
        {
            get { return HealthPoints < 0; }
        }
        #endregion

        #region Virtuals
        protected virtual double SetInitialHealthPoints()
        {
            return RNG.RandomDouble(1.0, _maxInitialHealthPoints);
        }

        protected virtual int SetInitialGoldOwned()
        {
            return RNG.RandomInt(0, _maxInitialGold);
        }

        protected virtual List<IItems> SetInitialItemsOwned()
        {
            List<IItems> initialItems = new List<IItems>();
            for (int i = 0; i < RNG.RandomInt(1,_maxInitialItems); i++)
            {
                initialItems.Add(GetInitialItems());
            }
            return initialItems;
        }
        public virtual IItems GetInitialItems()
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

        public virtual void AddItem(IItems item)
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
            string desc = $"{Name} has {GoldOwned} gold, and is at {HealthPoints:F1} HP \n" +
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
