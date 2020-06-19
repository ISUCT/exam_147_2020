namespace ExamApp
{
    public class KnightMove : IMove
    {
        public  void Move(Chessmen who)
        {
            who.X += 1;
            who.Y += 2;
        }
    }
}