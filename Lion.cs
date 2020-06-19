using System;

namespace exam_147_2020
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
            return $"Lion habitat is {Location} within {Boundaries}";
        }
        public override string Eat()
        {
            return "Lion won fight against lone befalo and ate him";
        }
        public override string MakeNoise()
        {
            return "Lion roars loudly";
        }
    }
}