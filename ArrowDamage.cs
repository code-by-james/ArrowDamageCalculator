using System;
using System.Collections.Generic;
using System.Text;

namespace ArrowDamageCalculator
{
    class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        /// <summary>
        /// Calculate sword damage based on default values and a starting roll;
        /// </summary>
        /// <param name="startingRoll">Stating 3d6 roll</param>
        public ArrowDamage(int startingRoll) : base(startingRoll) { }
        

        /// <summary>
        /// Calcualte the damage based on the sword properties
        /// </summary>
        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;

            if (Magic)
            {
                baseDamage *= MAGIC_MULTIPLIER;
            }

            if (Flaming)
            {
                Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            }
            else
            {
                Damage = (int)Math.Ceiling(baseDamage);
            }
        }



    }
}
