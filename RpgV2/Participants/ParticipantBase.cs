using RpgV2.GameManagement;
using RpgV2.Helpers;
using RpgV2.Interfaces;
using RpgV2.Items.Armor;
using RpgV2.Items.Weapons;

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
        private int _maxInitialArmor;
        private int _maxInitialWeapons;
        private double _meleeMaxDamage;
        #endregion

        #region Properties
        public virtual string Name { get; }
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }

        public bool IsDead
        {
            get { return HealthPoints <= 0; }
        }

        public double ArmorPoints
        {
            get { return ArmorOwned.Count == 0 ? 
                    0 : ArmorOwned.Select(a => a.ArmorPoints).Average(); }
        }
         //TODO: LANDMINE !!!!!



        #endregion

        #region Constructor

        protected ParticipantBase(
            int maxInitialHealthPoints,
            int maxInitialGold,
            int maxInitialArmor,
            int maxInitialWeapons,
            double meleeMaxDamage, 
            string name
            )
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

        #region virtual Methods

        protected virtual List<IWeapon> SetInitialWeaponsOwned()
        {
            var initialWeapons = new List<IWeapon>();
            for (int i = 0; i < RNG.RandomInt(0, _maxInitialArmor); i++)
            {
                initialWeapons.Add(GameFactory.Instance().WeaponFactory.CreateWeapon());
            }
            return initialWeapons;
        }

        protected virtual List<IArmor> SetInitialArmorOwned()
        {
            var initialArmor = new List<IArmor>();
            for (int i = 0; i < RNG.RandomInt(0, _maxInitialArmor); i++)
            {
                initialArmor.Add(GameFactory.Instance().ArmorFactory.CreateArmor());
            }
            return initialArmor;
        }

        protected virtual double SetInitialHealthPoints()
        {
            return RNG.RandomDouble(1.0, _maxInitialHealthPoints);
        }

        protected virtual int SetInitialGoldOwned()
        {
            return RNG.RandomInt(0, _maxInitialGold);
        }

        

        public virtual IItem GetInitialItem()
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
                    return new IronSword();
                case 6:
                    return new SteelLance();
                case 7:
                    return new WoodenMace();
                default:
                    throw new Exception($"Could not generate item with index {index} ");
            }
        }

        public virtual double DealDamage()
        {
            return RNG.RandomDouble(0.0, _meleeMaxDamage);

            //TODO: Figure out With weapon that is best and deal the damage from that weapon.
            //TODO Hint: SELECT(W => W.æsdæfkæsdlfksæ).MAX()
        }

        public virtual void ReceiveDamage(double damagePoints)
        {
            HealthPoints -= damagePoints;
        }

        public virtual void AddArmor(IArmor armor)
        {
            ArmorOwned.Add(armor);
        }

        public virtual void AddWeapon(IWeapon weapon)
        {
            WeaponsOwned.Add(weapon);
        }

        public virtual void ClearItems()
        {
            ArmorOwned.Clear();
            WeaponsOwned.Clear();
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            string desc = $"{Name} has {GoldOwned} gold, " +
                $"and is at {HealthPoints:F1} health points\n " +
                $"and has {ArmorPoints:F1} armor points\n";
                desc += $"{Name} owns {ArmorOwned.Count}armor items:\n";

            foreach (var armor in ArmorOwned)
            {
                desc += $"{armor}\n";
            }

            desc += $"{Name} ownes {WeaponsOwned.Count} weapons item:\n";

            foreach (var weapon in WeaponsOwned)
            {
                desc += $"{weapon}\n";
            }

            return desc;
        }


        #endregion
    }
}
