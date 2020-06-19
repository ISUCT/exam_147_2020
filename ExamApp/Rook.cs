using System.Collections.Generic;
namespace ExamApp
{
    public class Rook : Chessmen
    {
        public Rook()
        {
            Moves = new List<IMove>(){ new RookMove()};
            X = 2;
            Y = 0;
        }
        public override string Name { get; set; } = "Ладья";
    }
}