using System;
using Xunit;
using Chess;

namespace Chess.Tests
{
    public class ChessTests
    {
        [Fact]
        public void PawnEatsRookTest()
        {
            Figure figure = new Pawn("Белый");
            Figure figure1 = new Rook("Черный");
            Assert.Equal("Фигура Пешка (Белый) съедает Ладья (Черный)", figure.Eat(figure1));
        }

        [Fact]
        public void KnightEatsRookTest()
        {
            Figure figure = new Knight("Черный");
            Figure figure1 = new Rook("Белый");
            Assert.Equal("Фигура Конь (Черный) съедает Ладья (БелыйфФигура Конь (Черный) съедает Ладья (Белый)", figure.Eat(figure1));
        }

        [Fact]
        public void RookEatsPawnTest()
        {
            Figure figure = new Rook("Черный");
            Figure figure1 = new Pawn("Белый");
            Assert.Equal("Фигура Ладья (Черный) съедает Пешка (Белый)", figure.Eat(figure1));
        }

        [Fact]
        public void SameColorTest()
        {
            Figure figure = new Rook("Черный");
            Figure figure1 = new Pawn("Черный");
            Assert.Equal("Нельзя съесть фигуру того же цвета", figure.Eat(figure1));
        }

        [Fact]
        public void WalksTest()
        {
            Figure figure = new Pawn("Черный");
            Figure figure1 = new Rook("Черный");
            Figure figure2 = new Knight("Черный");
            Assert.Equal("Пешка ходит по прямой на одну клетку, при старте может сходиться на две клетки", figure.Walk());
            Assert.Equal("Ладья ходит прямо по вертикали и горизонтали в обе стороны", figure1.Walk());
            Assert.Equal("Конь ходит буквой Г, передвигаясь на две клетки и затем сворачивая на одно поле налево или направо", figure2.Walk());
        }
    }
}
