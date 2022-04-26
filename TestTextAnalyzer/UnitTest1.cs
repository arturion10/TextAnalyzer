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
    }
}