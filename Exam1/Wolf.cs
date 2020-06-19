using System;

namespace Exam1
{
    public class Wolf : Animals
    {
        public Wolf(string loc,string bound)
        {
            Location = loc;
            Boundaries = bound;
        }
        public string Info()
        {
            return $"место обитания волка - {Location}, {Boundaries}";
        }

        public override string Eat()
        {
            return "волк поймал зайца и съел";
        }
        public override string MakeNoise()
        {
            return "волк воет на луну";
        }
    }
}