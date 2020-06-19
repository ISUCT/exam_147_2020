namespace ExamApp
{
    public class Wolf : Animals
    {
        public Wolf()
        :base()
        {}
        public Wolf(string location, string boundaries)
        :base(location, boundaries)
        {}

        public override string Sleep()
        {
            return "Wolf is asleep.";
        }

        public override string Roam()
        {
            return $"Wolf roams - {Location},{Boundaries}.";
        }
        public override string Eat()
        {
            return "The wolf eats the rabbit.";
        }
        public override string MakeNoise()
        {
            return "The wolf howls at the moon.";
        }
    }
}