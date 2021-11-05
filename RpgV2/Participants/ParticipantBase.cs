using RpgV2.GameMangement;
using RpgV2.Helpers;
using RpgV2.Interfaces;
using RpgV2.Interfaces.Factories;
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

        public virtual string Name { get; set; }
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
            get 
            {
                return ArmorOwned.Count == 0 ?
                  0 : ArmorOwned.Select(a => a.ArmorPoints).Sum(); 
            }
        }
        #endregion

        #region Constructor
        protected ParticipantBase(int maxInitialHealthPoints, int maxInitialGold, int maxInitialArmor, int maxInitialWeapons, double meleeMaxDamage, string name)
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

        #region Virtual Methods
        protected virtual List<IArmor> SetInitialArmorOwned()
        {
            var initialArmor = new List<IArmor>();
            for (int i = 0; i < RNG.RandomInt(0, _maxInitialArmor); i++)
            {
                initialArmor.Add(GameFactory.Instance().ArmorFactory.CreateArmor());
            }
            return initialArmor;
        }

        protected virtual List<IWeapon> SetInitialWeaponsOwned()
        {
            var initialWeapons = new List<IWeapon>();
            for (int i = 0; i < RNG.RandomInt(0, _maxInitialWeapons); i++)
            {
                initialWeapons.Add(GameFactory.Instance().WeaponFactory.CreateWeapon());
            }
            return initialWeapons;
        }
        protected virtual double SetInitialHealthPoints()
        {
            return RNG.RandomDouble(1.0, _maxInitialHealthPoints);
        }

        public virtual int SetInitialGoldOwned()
        {
            return RNG.RandomInt(0, _maxInitialGold);
        }

        public virtual double DealDamage()
        {
            //SELECT THE STRONGEST WEAPON - Use max damage if weapon is not present
            var strongestWeap = WeaponsOwned.Count != 0 ? WeaponsOwned.Select(w => w.MaxWeaponDamage).Max() : _meleeMaxDamage;
            return RNG.RandomDouble(0.0, strongestWeap);

        }

        public virtual void ReceiveDamage(double damagePoints)
        {
            //Console.WriteLine($"{Name} RECEIVED {damagePoints}");
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
            WeaponsOwned.Clear();
            ArmorOwned.Clear();
        }
        public virtual IItem GetInitialItems()
        {
            int index = RNG.RandomInt(1, 7);
            return index switch
            {
                1 => new ClothGloves(),
                2 => new LeatherBoots(),
                3 => new PlateBoots(),
                4 => new WoodenShield(),
                5 => new IronSword(),
                6 => new SteelLance(),
                7 => new WoodenMace(),
                _ => throw new Exception($"Could not generate item with index {index} "),
            };
        }

        #endregion
        #region Methods
        public override string ToString()
        {
            string desc = $"{Name} has {GoldOwned} gold and is at {HealthPoints:F1} health points\n" +
                $"and has {ArmorPoints:F1} armorpoints\n";
                desc += $"{Name} owns {ArmorOwned.Count} armor items:\n";

            foreach (var armor in ArmorOwned)
            {
                desc += $"{armor}\n";
            }

            desc += $"{Name} owns {WeaponsOwned.Count} weapon items:\n";

            foreach (var weapon in WeaponsOwned)
            {
                desc += $"{weapon}\n";
            }

            return desc;
        }
        #endregion
    }
}
