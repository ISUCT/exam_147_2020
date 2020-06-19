using Xunit;
using System;
using ExamApp;

namespace ExamApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CurrentBishopCoordinatesTest()
        {
            var a = new Bishop();
            Equals(0, a.X);
        }
        [Fact]
        public void CurrentNameTest()
        {
            var a = new Rook();
            Equals("Ладья", a.Name);
        }

        [Fact]
        public void CurrMoveTest()
        {
            var a = new Pawn();
            a.Move();
            Equals(3, a.X);
        }

        [Fact]
        public void EatTest()
        {
            var a = new Pawn();
            var b = new Bishop();
            a.Eat(b);
            Equals(!b.IsAlive);
        }
    }
}
