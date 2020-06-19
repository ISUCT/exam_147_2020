using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Figure : IMove
    {
        public Figure(string color)
        {
            Color = color;
        }

        private string color;
        private string name;
        public virtual string Color { 
            get
            {
                return color;
            }
            set
            {
                if(value == "Белый" || value == "Черный")
                {
                    color = value;
                }
                else
                {
                    return;
                }
            }
        }
        public virtual string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            } 
        }

        public virtual string Walk()
        {
            return "Способ хода не назначен";
        }

        public string Eat(Figure figure)
        {
            if(figure.Color == this.Color)
            {
                return "Нельзя съесть фигуру того же цвета";
            }
            else
            {
                return $"Фигура {this.Name} ({this.Color}) съедает {figure.Name} ({figure.Color})";
            }
        }
    }
}
