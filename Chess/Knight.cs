using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Knight : Figure
    {
        public Knight(string color)
            :base(color)
        {
            Name = "Конь";
        }
        public override string Walk()
        {
            return $"{this.Name} ходит буквой Г, передвигаясь на две клетки и затем сворачивая на одно поле налево или направо";
        }
    }
}
