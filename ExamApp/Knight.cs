using System.Collections.Generic;
namespace ExamApp
{
    public class Knight : Chessmen
    {
        public Knight()
        {
            Moves = new List<IMove>(){ new KnightMove()};
            X = 2;
            Y = 0;
        }
        public override string Name { get; set; } = "Конь";
    }
}