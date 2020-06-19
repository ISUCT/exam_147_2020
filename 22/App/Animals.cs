using System;

namespace app
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
                if (value != null)
                {
                    this.location = value;
                }
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
                if (value != null)
                {
                    this.boundaries = value;
                }
            }
        }
        public string Sleep()
        {
            return "the animal is asleep";
        }
        public string Roam()
        {
            return "the animal walks";
        }
        public abstract string Eat();
        public abstract string MakeNoise();
    }
}