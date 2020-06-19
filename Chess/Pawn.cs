using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Pawn : Figure
    {
        public Pawn(string color)
            :base(color)
        {
            Name = "Пешка";
        }
        public override string Walk()
        {
            return $"{this.Name} ходит по прямой на одну клетку, при старте может сходиться на две клетки";
        }
    }
}
