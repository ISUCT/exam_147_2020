using System;

namespace Exam1
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
            return "животное спит";
        }
        public string Roam()
        {
            return "животное бродит туда-сюда";
        }
        public abstract string Eat();
        public abstract string MakeNoise();
    }
}