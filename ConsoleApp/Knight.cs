namespace ExamApp
{
    public class Pawn : Chessmen
    {
        public Pawn()
        {
            Y = 0;
            X = 0;
        }
        public override string Name { get; set; } = "Пешка";
        public override void Move()
        {
            Y += 1;
            X = 0;
        }
    }
}