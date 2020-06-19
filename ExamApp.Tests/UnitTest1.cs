using System;
using Xunit;
using ExamApp;


namespace ExamApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CurrentBishopCoordinatesTest()
        {
            var a = new Bishop();
            Assert.Equal(0, a.X);
        }
        [Fact]
        public void CurrentNameTest()
        {
            var a = new Rook();
            Assert.Equal("Ладья", a.Name);
        }

        [Fact]
        public void CurrMoveTest()
        {
            var a = new Knight();
            a.Move();
            Assert.Equal(3, a.X);
        }

        [Fact]
        public void EatTest()
        {
            var a = new Knight();
            var b = new Bishop();
            a.Eat(b);
            Assert.True(!b.IsAlive);
        }
    }
}
