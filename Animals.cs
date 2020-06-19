using System;

namespace exam_147_2020
{
    public abstract class Animals
    {
        private string location;
        private string boundaries;

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                this.location = value;
            }
        }
        public string Boundaries
        {
            get
            {
                return boundaries;
            }

            set
            {
                this.boundaries = value;
            }
        }
        public string Sleep()
        {
            return "Creature is now asleep";
        }
        public string Roam()
        {
            return "Creature is brodit";
        }
        public abstract string Eat();
        public abstract string MakeNoise();
    }
}