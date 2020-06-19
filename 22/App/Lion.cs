using System;

namespace app
{
    public class Lion : Animals
    {
        public Lion(string loc, string bound)
        {
            Location = loc;
            Boundaries = bound;
        }
        public string Info()
        {
            return $"the habitat of the lion - {Location}, {Boundaries}";
        }
        public override string Eat()
        {
            return "lion caught the Zebra and ate";
        }
        public override string MakeNoise()
        {
            return "lion growled loudly";
        }
    }
}