namespace ExamApp
{
    public class Knight : Chessmen
    {
        public Knight()
        {
            X = 2;
            Y = 0;
        }
        public override string Name { get; set; } = "Конь";
        public override void Move()
        {
            X += 1;
            Y += 2;
        }
    }
}