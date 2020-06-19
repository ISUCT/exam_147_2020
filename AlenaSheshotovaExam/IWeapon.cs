using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public interface IWeapon
    {
        double MakeDamage(double protection);
        void UseAbility(Hero target);

    }
}
