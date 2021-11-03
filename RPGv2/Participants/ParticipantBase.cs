using RPGv2.Helpers;
using RPGv2.Interfaces;
using RPGv2.Items.Armor;
using RPGv2.Items.Weapons;
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

        #region Constructor 
        protected ParticipantBase(int maxInitialHealthPoints, int maxInitialGold, int maxInitialItems, double maxDamage, string name)
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
            switch (index)
            {
                case 1:
                    return new ClothGloves();
                case 2:
                    return new LeatherBoots();
                case 3:
                    return new PlateBoots();
                case 4:
                    return new WoodenShield();
                case 5:
                    return new WoodenMace();
                case 6:
                    return new IronSword();
                case 7:
                    return new SteelLance();
                default:
                    throw new Exception($"Could not generate item with index {index}");
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
