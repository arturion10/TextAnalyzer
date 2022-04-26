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
            // Arrange (����������)
            var word = "abc";

            // Act (��������, ������� ���������)
            var result = logic.ReverceString(word);

            // Assert (�������� ����������)
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
            var word = "����";
            var result = logic.IsReverseString(word);
            Assert.True(result);
        }
        [Fact]
        public void IsReverseString_WithUpper()
        {
            var word = "����";
            var result = logic.IsReverseString(word);
            Assert.True(result);
        }
        [Fact]
        public void IsReverseString_False()
        {
            var word = "����";
            var result = logic.IsReverseString(word);
            Assert.False(result);
        }
    }
}