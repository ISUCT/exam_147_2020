using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class MagicWand : Weapon, IWeapon
    {
        private bool AbilityActive;

        public MagicWand(string name, double damage) : base(name, damage)
        {
            AbilityActive = true;
        }

        public double MakeDamage(double protection)
        {
            double result = Damage - protection / 4;
            return result > 0 ? result : 0;
        }

        public void UseAbility(Hero target)
        {
            if (AbilityActive)
            {
                AbilityActive = false;
                target.DamageArmor(100);
            }
        }

        public override string ToString()
        {
            return $"Тип: Магический жезл\n" +
                   $"Имя: {Name}\n" +
                   $"Урон: {Damage}\n" +
                   $"Способность: Обнуление брони";
        }
    }
}
