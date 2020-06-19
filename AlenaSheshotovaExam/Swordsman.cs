﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaSheshotovaExam
{
    public class Swordsman : Hero
    {
        private double DodgeChance; 


        public Swordsman(string name, double health, double armor, IWeapon weapon, double dodgeChance) : base(name, health, armor, weapon)
        {
            if (dodgeChance < 0) DodgeChance = 0;
            else if (dodgeChance > 95) DodgeChance = 95;
            else DodgeChance = dodgeChance;
        }

        public override void TakeDamage(double damage)
        {
            if (!Dead)
            {
                if(Program.random.Next(0,101) > DodgeChance)
                {
                    Health -= damage;
                    Dead = Health <= 0;
                }         
            }
        }
    }
}
