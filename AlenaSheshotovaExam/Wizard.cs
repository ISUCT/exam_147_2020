using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class Wizard : Hero
    {
        private double PowerMagic;

        public Wizard(string name, double health, double armor, IWeapon weapon, double powerMagic) : base(name, health, armor, weapon)
        {
            PowerMagic = powerMagic;
        }

        public override void Healing(double qty)
        {
            base.Healing(qty + PowerMagic);
        }
    }
}
