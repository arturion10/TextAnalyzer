using TextAnalyzer;
using Xunit;

namespace TestTextAnalyzer
{
    public class StringLogicTest
    {
        private StringLogic logic;
        public StringLogicTest()
        {
            logic = new StringLogic();
        }

        [Fact]
        public void ReverseString_Three()
        {
            // Arrange (подготовка)
            var word = "abc";

            // Act (Действие, которое тестируем)
            var result = logic.ReverceString(word);

            // Assert (Проверка результата)
            Assert.Equal("cba", result);
        }
        [Fact]
        public void ReverseString_Four()
        {
            var word = "abcd";

            var result = logic.ReverceString(word);

            Assert.Equal("dcba", result);
        }

        [Fact]
        public void IsReverseString_True()
        {
            var word = "анна";

            var result = logic.IsReverseString(word);

            Assert.True(result);
        }
        [Fact]
        public void IsReverseString_WithUpper()
        {
            var word = "Анна";

            var result = logic.IsReverseString(word);

            Assert.True(result);
        }
        [Fact]
        public void IsReverseString_False()
        {
            var word = "Анне";

            var result = logic.IsReverseString(word);

            Assert.False(result);
        }
        [Fact] 
        public void ReverceCharDegreeOfNumber_TwoChar()
        {
            var word = "Привет";
            var num = 2;

            var result = logic.ReverceCharDegreeOfNumber(word, num);

            Assert.Equal("рвиПет", result);
        }
        [Fact]
        public void ReverceCharDegreeOfNumber_ThreeChar()
        {
            var word = "Привет";
            var num = 3;

            var result = logic.ReverceCharDegreeOfNumber(word, num);

            Assert.Equal("ирПвет", result);
        }
        [Fact]
        public void SpecifiesHowManyVowels_ToLower()
        {
            var st = "Привет Мир";
            var num = 3;

            var result = logic.SpecifiesHowManyVowels(st);

            Assert.Equal(result, num);
        }
        [Fact]
        public void SpecifiesHowManyVowels_ToUpper()
        {
            var st = "Привет Мир Японии";
            var num = 7;

            var result = logic.SpecifiesHowManyVowels(st);

            Assert.Equal(result, num);
        }
    }
}