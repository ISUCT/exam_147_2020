namespace ExamApp
{
    public class BishopMove : IMove
    {
        public void Move(Chessmen who)
        {
            who.Y += 2;
        }
    }
}