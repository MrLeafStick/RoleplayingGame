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
            get { return ArmorOwned.Count == 0 ? _maxInitialArmor : ArmorOwned.Select(a => a.ArmorPoints).Average() + _maxInitialArmor; }
        }

        



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
            for (int i = 0; i < RNG.RandomInt(0, _maxInitialWeapons); i++)
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

            return index switch
            {
                1 => new ClothGloves("Silk Smooth"),
                2 => new LeatherBoots("Cow skin leather boots"),
                3 => new PlateBoots("Polished plate boots"),
                4 => new WoodenShield("Viking shield"),
                5 => new IronSword("Sharpened sword", 30, 70),
                6 => new SteelLance("Long stick", 20, 50),
                7 => new WoodenMace("Broken Club", 10, 30),
                _ => throw new Exception($"Could not generate item with index {index} "),
            };
        }

        public virtual double DealDamage()
        {
            if(WeaponsOwned.Count == 0)
            {
                return RNG.RandomDouble(0.0, _meleeMaxDamage);
            } else
            {
                // #1 Finds the weapon with the highest average damage then returns a damage between min & max damage - ugly, but fastest and right way
                IWeapon highestAverageDamageWeapon = WeaponsOwned[0];
                for (int i = 1; i < WeaponsOwned.Count; i++)
                {
                    if (WeaponsOwned[i].AverageWeaponDamage > highestAverageDamageWeapon.AverageWeaponDamage)
                    {
                        highestAverageDamageWeapon = WeaponsOwned[i];
                    }
                }
                return RNG.RandomDouble(highestAverageDamageWeapon.MinWeaponDamage, highestAverageDamageWeapon.MaxWeaponDamage);


                // #2 Finds the highest average damage of the weapons, then finds the weapon with the average damage and returns a damage between min & max damage
                //int weaponAverageDamage = WeaponsOwned.Select(w => w.AverageWeaponDamage).Max();
                //IWeapon highestAverageDamageWeapon = WeaponsOwned.Find(w => w.AverageWeaponDamage == weaponAverageDamage);
                //return RNG.RandomDouble(highestDamageWeapon.MinWeaponDamage, highestDamageWeapon.MaxWeaponDamage);


            }



            //TODO: Figure out which weapon is best and deal the damage from that weapon.   done 
            //TODO Hint: SELECT(W => W.æsdæfkæsdlfksæ).MAX()    <- returner et tal (int eller double)
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
                desc += $"{Name} owns {ArmorOwned.Count} armor items:\n";

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
