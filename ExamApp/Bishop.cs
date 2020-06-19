using System.Collections.Generic;
namespace ExamApp
{
    public class Bishop : Chessmen
    {
        public Bishop()
        {
            Moves = new List<IMove>(){ new BishopMove()};
            this.X = 0;
            this.Y = 0;
        }

        public override string Name { get; set; } = "Слон";
    }
}