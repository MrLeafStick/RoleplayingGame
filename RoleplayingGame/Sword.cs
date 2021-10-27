using System;

namespace RoleplayingGame
{
    public class Sword
    {
        #region Instance Fields
        private string _name;
        private int _MaxDamage;
        private int _minDamage;
        private Random _generator;

        #endregion

        #region Constructor
        public Sword(string name, int maxDamage, int minDamage)
        {
            _name = name;
            _MaxDamage = maxDamage;
            _minDamage = minDamage;
            _generator = new Random(Guid.NewGuid().GetHashCode());
        }
        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        #endregion

        #region Methods
        public int DealDamge() 
        {
            return _generator.Next(_minDamage, _MaxDamage);
        }

        #endregion




    }
}