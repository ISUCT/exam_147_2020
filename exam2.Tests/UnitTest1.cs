using System;
using Xunit;
using Anagrams;

namespace Anagrams.Tests
{
    public class AnagramsTests
    {
        [Fact]
        public void WordsCatAndCot()
        {
           Assert.Equal("Следует заменить 1 букв(-ы)" ,Program.Anagrams("cat", "cot"));
        }

        [Fact]
        public void WordsCarAndCoz()
        {
            Assert.Equal("Следует заменить 2 букв(-ы)" ,Program.Anagrams("accept", "except"));
        }

        [Fact]
        public void WordsCarsAndCat()
        {
            Assert.Equal("Данные слова уже являются анаграммами" ,Program.Anagrams("affect", "effect"));
        }

        [Fact]
        public void WordsDeerAndDeep()
        {
            Assert.Equal("Следует заменить 1 букв(-ы)" ,Program.Anagrams("deer", "deep"));
        }

        [Fact]
        public void WordsMrahAndHarm()
        {
            Assert.Equal("Следует заменить 1 букв(-ы)" ,Program.Anagrams("principle", "principal"));
        }

        [Fact]
        public void WordsDarkAndYyyy()
        {
            Assert.Equal("Следует заменить 1 букв(-ы)" ,Program.Anagrams("current", "currant"));
        }

        [Fact]
        public void WordsAgarAndGras()
        {
            Assert.Equal("Следует заменить 4 букв(-ы)" ,Program.Anagrams("agar", "time"));
        }
    }
}