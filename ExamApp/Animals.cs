using System;

namespace ExamApp
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

        public Animals()
        {
            Location = "World";
            Boundaries = "Unknown";
        }

        public Animals(string location, string boundaries)
        {
            Location = location;
            Boundaries = boundaries;
        }

        public virtual string Sleep()
        {
            return "Animal is asleep.";
        }

        public virtual string Roam()
        {
            return "Animal roams.";
        }
        public abstract string Eat();
        public abstract string MakeNoise();
    }
}