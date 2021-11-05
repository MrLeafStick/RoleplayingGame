using RPG_V2.GameManagement;
using RPG_V2.Helpers;
using RPG_V2.Interfaces;
using RPG_V2.Items.Armour;
using RPG_V2.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_V2.Participants
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
        public virtual string Name { get;}
        public double HealthPoints { get; private set; }
        public int GoldOwned { get; set; }
        public List<IArmor> ArmorOwned { get; }
        public List<IWeapon> WeaponsOwned { get; }
        public bool MyProperty { get; set; }
        public bool IsDead { get { return HealthPoints <= 0; } }
        public double ArmorPoints
        {
            get { return ArmorOwned.Count == 0 ? 0 : ArmorOwned.Select(a => a.ArmorPoints).Sum(); }
        }
        #endregion

        #region Constructors
        protected ParticipantBase(  int maxInitialHealthPoints, 
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

        private List<IWeapon> SetInitialWeaponsOwned()
        {
            var initalWeapons = new List<IWeapon>();
            for (int i = 0; i < RNG.RandomInt(1, _maxInitialWeapons); i++) // TODO: initialWeapons cannot be 0;
            {
                initalWeapons.Add(GameFactory.Instance().WeaponFactory.CreateWeapon());
            }
            return initalWeapons;
        }

        protected virtual List<IArmor> SetInitialArmorOwned()
        {
            var initalArmor = new List<IArmor>();
            for(int i = 0; i < RNG.RandomInt(0, _maxInitialArmor); i++)
            {
                initalArmor.Add(GameFactory.Instance().ArmorFactory.CreateArmor());
            }
            return initalArmor;
        }
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

        

        public virtual double DealDamage()
        {
            return WeaponsOwned.Count > 0 ? WeaponsOwned.Select(weapon => weapon.MaxWeaponDamage).Max() : 0;
            //TODO: Landmine!
        }

        public virtual void ReceiveDamage(double damagePoints)
        {
            HealthPoints -= damagePoints;
        }

        public virtual void AddArmor(IArmor armor)
        {
            ArmorOwned.Add(armor);
        }

        public virtual void AddWeapons(IWeapon weapon)
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
            int index = RNG.RandomInt(1, 7);

            switch(index)
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
                    return new WoodMace();
                default:
                    throw new Exception($"Could not generate item with index {index}");
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string desc = $"{Name} has {GoldOwned} gold, " +
                $"{HealthPoints:F1} health points " +
                $"and {ArmorPoints:F1} armor points\n";

                desc += $"{Name} owns {ArmorOwned.Count} armor items: \n";

                foreach (var armor in ArmorOwned)
                {
                    desc += $"  {armor} ({armor.ArmorPoints})\n";
                }

                desc += $"{Name} owns {WeaponsOwned.Count} weapon items: \n";

                foreach (var weapon in WeaponsOwned)
                {
                    desc += $"  {weapon} ({weapon.MaxWeaponDamage})\n";
                }

            return desc;
        }
        #endregion

    }
}
