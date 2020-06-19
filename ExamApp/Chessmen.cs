using System.Collections.Generic;
using System;

namespace ExamApp
{
    public abstract class Chessmen
    {
        Random rnd = new Random();
        int x, y;
        public bool IsAlive { get; set; } = true;
        public abstract string Name { get; set; }
        protected List<IMove> Moves { get; set; }

        public int X
        {
            get { return this.x; }
            set
            {
                if (value >= 0 && value <= 8) this.x = value;
                else throw new System.ArgumentOutOfRangeException("uncorrect value");
            }
        }
        public int Y
        {
            get { return this.y; }
            set
            {
                if (value >= 0 && value <= 8) this.y = value;
                else throw new System.ArgumentOutOfRangeException("uncorrect value");
            }
        }
        public void Eat(Chessmen who)
        {
            who.IsAlive = false;
        }
        public void MakeAMove()
        {
            this.Moves[rnd.Next(0, Moves.Count)].Move(this);
        }
    }
}