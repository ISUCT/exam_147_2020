using System;

namespace ExamApp
{
    public class Lion : Animals
    {
        public Lion()
        :base()
        {}
        public Lion(string location, string boundaries)
        :base(location, boundaries)
        {}

        public override string Sleep()
        {
            return "Lion is asleep.";
        }

        public override string Roam()
        {
            return $"Lion roams - {Location},{Boundaries}.";
        }
        public override string Eat()
        {
            return "A lion has caught a Zebra and is eating it.";
        }
        public override string MakeNoise()
        {
            return "The lion roars.";
        }
    }
}