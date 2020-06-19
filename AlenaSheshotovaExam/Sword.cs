using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class Sword : Weapon, IWeapon
    {
        private bool AbilityActive;

        public Sword(string name, double damage) : base(name, damage)
        {
            AbilityActive = true;
        }

        public double MakeDamage(double protection)
        {
            double result = Damage - protection;
            return result > 0 ? result : 0;
        }

        public void UseAbility(Hero target)
        {
            if(AbilityActive)
            {
                AbilityActive = false;
                target.Healing(10);
            }           
        }

        public override string ToString()
        {
            return $"Тип: Меч\n" +
                   $"Имя: {Name}\n" +
                   $"Урон: {Damage}\n" +
                   $"Способность: исцеление"; 
        }
    }
}
