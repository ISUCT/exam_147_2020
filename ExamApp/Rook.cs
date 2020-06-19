namespace ExamApp
{
    public class Rook : Chessmen
    {
        public Rook()
        {
            X = 2;
            Y = 0;
        }
        public override string Name { get; set; } = "Ладья";
        public override void Move()
        {
            Y += 2;
        }
    }
}