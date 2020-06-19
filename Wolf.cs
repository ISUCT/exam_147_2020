using System;

namespace exam_147_2020
{
    public class Wolf : Animals
    {
        public Wolf(string _location,string _boundaries)
        {
            Location = _location;
            Boundaries = _boundaries;
        }
        public string Info()
        {
            return $"bonk habitat is {Location} within {Boundaries}";
        }

        public override string Eat()
        {
            return "bonk ate random citizen";
        }
        public override string MakeNoise()
        {
            return "bonk said 'bonk'";
        }
    }
}