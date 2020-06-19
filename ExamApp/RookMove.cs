namespace ExamApp
{
    public class RookMove : IMove
    {
        public void Move(Chessmen who)
        {
            who.X += 2;
            who.Y += 2;
        }
    }
}