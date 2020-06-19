using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Rook : Figure
    {
        public Rook(string color)
            :base(color)
        {
            Name = "Ладья";
        }
        public override string Walk()
        {
            return $"{this.Name} ходит прямо по вертикали и горизонтали в обе стороны";
        }
    }
}
