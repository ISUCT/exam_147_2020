using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using Xunit;

namespace exApp.XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void BasicWork()
        {
            List<int> a = new List<int>() { 1, 4, -11, -5, 55, -55 };
            List<int[]> list = Program.GetZeroSumms(a);
            if ((list[0] == new int[2] { -50,50}) && (list[1] == new int[2] { -7,7 }))
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void NoResult()
        {
            List<int> a = new List<int>() { 1, 4, -11, -55 };
            List<int[]> list = Program.GetZeroSumms(a);
            Assert.Equal(new List<int[]>(), list);
        }

        [Fact]
        public void EmptyInput()
        {
            List<int> a = new List<int>();
            List<int[]> list = Program.GetZeroSumms(a);
            Assert.Equal(new List<int[]>(), list);
        }

        [Fact]
        public void MultipleEqualNumbers()
        {
            List<int> a = new List<int>() { 1, 4, -11, -5, 55, -55, 5, -55 };
            List<int[]> list = Program.GetZeroSumms(a);
            if ((list[0] == new int[2] { -50, 50 }) && (list[1] == new int[2] { -7, 7 }) && list.Count == 2)
            {
                Assert.True(true);
            }
        }
    }
}
