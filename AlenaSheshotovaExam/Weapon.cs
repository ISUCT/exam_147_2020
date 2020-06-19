using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class Weapon
    {
        public string Name { get; protected set; }
        public double Damage { get; protected set; }

        public Weapon(string name, double damage)
        {
            Name = name;
            Damage = damage;
        }
        
    }
}
