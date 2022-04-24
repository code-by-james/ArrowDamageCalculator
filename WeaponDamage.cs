using System;
using System.Collections.Generic;
using System.Text;

namespace ArrowDamageCalculator
{
    class WeaponDamage
    {

        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        /// <summary>
        /// Contains the calculated damage
        /// </summary>
        public int Damage { get; protected set; }

        /// <summary>
        /// Sets or gets the 3d6 roll
        /// </summary>
        private int roll;        
        public int Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool magic;

        /// <summary>
        /// True if the sword is magic, false otherwise
        /// </summary>
        public bool Magic
        {
            get
            {
                return magic;
            }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;

        /// <summary>
        /// True if the sword is flaming, false otherwise
        /// </summary>
        public bool Flaming
        {
            get
            {
                return flaming;
            }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// Calculate the damage based on the weapon properties
        /// </summary>
        protected virtual void CalculateDamage()
        {
            /* overridden by subclass */
        }
    }
}
