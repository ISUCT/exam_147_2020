namespace ExamApp
{
    public class Bishop : Chessmen
    {
        public Bishop()
        {
            this.X = 0;
            this.Y = 0;
        }

        public override string Name { get; set; } = "Слон";

        public override void Move()
        {
            Y += 2;
        }
    }
}