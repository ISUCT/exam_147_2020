using System.Collections.Generic;
using Xunit;

namespace ConsoleApp1
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectTest()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dict.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dict["a"].Add("b", new Dictionary<string, string>());
            dict["a"]["b"].Add("c", "12");
            dict["a"]["b"].Add("d", "Hello World");
            Dictionary<string, string> correct = new Dictionary<string, string>();
            correct.Add("a/b/c", "12");
            correct.Add("a/b/d", "Hello World");
            Assert.Equal(correct, Program.Func(dict));
        }

        [Fact]
        public void EmptyTest()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            Assert.Equal(new Dictionary<string, string>(), Program.Func(dict));
        }
    }
}
