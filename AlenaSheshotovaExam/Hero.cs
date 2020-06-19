using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class Hero
    {
        public string Name { get; protected set; }
        public double Health { get; protected set; }
        public double Armor { get; protected set; }
        public IWeapon Weapon { get; protected set; }
        public bool Dead { get; protected set; }

        public Hero(string name, double health, double armor, IWeapon weapon)
        {
            Name = name;
            Health = health > 10 || health < 100 ? health : 100;

            if (armor < 0) Armor = 0;
            else if (armor > 20) Armor = 20;
            else Armor = armor;
            Weapon = weapon;
        }

        public void TakeWeapon(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public virtual void TakeDamage(double damage)
        {
            if(!Dead)
            {
                Health -= damage;
                Dead = Health <= 0;
            }         
        }

        public void Attack(Hero target)
        {
            target.TakeDamage(Weapon.MakeDamage(target.Armor));
        }

        public virtual void Healing(double qty)
        {
            Health = Health + qty <= 100 ? Health + qty : 100;
        }

        public void DamageArmor(double qty)
        {
            Armor = Armor - qty >= 0 ? Armor - qty : 0;
        }

        public override string ToString()
        {
            return $"Тип: Герой\n" +
                   $"Имя: {Name}\n" +
                   $"Броня: {Armor}\n" +
                   $"Оружее: {Weapon.ToString()}";
        }
    }
}
