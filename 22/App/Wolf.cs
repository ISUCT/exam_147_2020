using System;

namespace app
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
            return $"habitat of a wolf - {Location}, {Boundaries}";
        }

        public override string Eat()
        {
            return "wolf caught the hare and ate";
        }
        public override string MakeNoise()
        {
            return "wolf howls at the moon";
        }
    }
}