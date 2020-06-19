using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class Bow : Weapon, IWeapon
    {
        private bool AbilityActive;

        public Bow(string name, double damage) : base(name, damage)
        {
            AbilityActive = true;
        }

        public double MakeDamage(double protection)
        {
            double result = Damage - protection / 2;
            return result > 0 ? result : 0;
        }

        public void UseAbility(Hero target)
        {
            if (AbilityActive)
            {
                AbilityActive = false;
                target.TakeDamage(2 * MakeDamage(target.Armor));
            }
        }

        public override string ToString()
        {
            return $"Тип: Лук\n" +
                   $"Имя: {Name}\n" +
                   $"Урон: {Damage}\n" +
                   $"Способность: Двойной урон";
        }
    }
}
