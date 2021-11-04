using RolePlayingGameV2.GameManagement;
using RolePlayingGameV2.Helpers;
using RolePlayingGameV2.Interfaces;
using RolePlayingGameV2.Items.Armors;
using RolePlayingGameV2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RolePlayingGameV2.Participants
{
    public abstract class ParticipantBase : IParticipant
    {
        #region Instance Fields
        private int _maxInitialHealthPoints;
        private int _maxInitialGold;
        private int _maxInitialArmor;
        private int _maxInitialWeapon;
        private double _maxMeleeDamage;
        #endregion

        #region Properties
        public virtual string Name { get; set; }
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }
        public bool IsDead { get { return HealthPoints <= 0; } }
        public double ArmorPoints { get { return ArmorOwned.Count == 0 ? 0 : ArmorOwned.Select(a => a.ArmorPoints).Average(); } }
        #endregion

        //TODO change average to sum...

        #region Virutal Methods
        protected virtual double SetInitialHealthPoints() 
        {
            return RNG.RandomDouble(1.0, _maxInitialHealthPoints);
        }
        protected virtual int SetInitialGoldOwned() 
        {
            return RNG.RandomInt(0, _maxInitialGold);
        }
        public virtual double DealDamage() 
        {
            return RNG.RandomDouble(0.0, _maxMeleeDamage);
            //TODO figure out weapon that is best and deal the damage from that weapon.
            //TODO HINT Select(W => W.af).MAX;
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
        public virtual IItem GetInitialItem() 
        {
            var index = RNG.RandomInt(1, 7);

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
                    return new WoodenMace();
                case 7:
                    return new SteelLance();
                default:
                    throw new Exception($"Could not generate item with index {index}");
            }

            return null; //TODO add weapons..
        }

        protected virtual List<IWeapon> SetInitialWeaponsOwend()
        {
            var initialWeapon = new List<IWeapon>();
            for (int i = 0; i < RNG.RandomInt(0, _maxInitialArmor); i++)
            {
                initialWeapon.Add(GameFactory.Instance().WeaponFactory.CreateWeapon());
            }
            return initialWeapon;
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
        #endregion

        #region Methods
        public override string ToString()
        {
            string desc = $"{Name} has {GoldOwned} gold, and is at {HealthPoints:F1} health points\n"
                + $"and has {ArmorPoints:F2} armor points\n";
            desc += $"{Name} owns {ArmorOwned.Count} armor items:\n";

            foreach (var armor in ArmorOwned)
            {
                desc += $"{armor}\n";
            }
            desc += $"{Name} owns {WeaponsOwned.Count} weapons:\n";

            foreach (var weapon in WeaponsOwned)
            {
                desc += $"{weapon}\n";
            }

            return desc;
        }
        #endregion

        #region Constructor
        protected ParticipantBase(int maxInitialHealthPoints, int maxInitialGold, int maxInitialArmor, int maxInitialWeapons, double maxMeleeDamage, string name)
        {
            _maxInitialHealthPoints = maxInitialHealthPoints;
            _maxInitialGold = maxInitialGold;
            _maxInitialArmor = maxInitialArmor;
            _maxInitialWeapon = maxInitialWeapons;
            _maxMeleeDamage = maxMeleeDamage;
            
            Name = name;

            HealthPoints = SetInitialHealthPoints();
            GoldOwned = SetInitialGoldOwned();
            ArmorOwned = SetInitialArmorOwned();
            WeaponsOwned = SetInitialWeaponsOwend();
        }
        #endregion
    }
}
