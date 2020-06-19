namespace ExamApp
{
    public class Rook : Chessmen
    {
        public Rook()
        {
            this.X = 0;
            this.Y = 0;
        }
        public override string Name { get; set; } = "Ладья";
        public override void Move()
        {
            this.Y += 2;
        }
    }
}