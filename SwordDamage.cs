using System;
using System.Collections.Generic;
using System.Text;

namespace ArrowDamageCalculator
{
    class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// Calculate sword damage based on default values and a starting roll;
        /// </summary>
        /// <param name="startingRoll">Stating 3d6 roll</param>
        public SwordDamage(int startingRoll) : base(startingRoll) { }

        /// <summary>
        /// Calculate the damage based on the sword properties
        /// </summary>
        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;

            if (Magic)
            {
                magicMultiplier = 1.75M;
            }

            Damage = BASE_DAMAGE;
            Damage += (int)(Roll * magicMultiplier);

            if (Flaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }



    }
}
