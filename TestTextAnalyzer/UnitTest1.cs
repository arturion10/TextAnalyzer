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
        [Fact] 
        public void ReverceCharDegreeOfNumber_TwoChar()
        {
            var word = "������";
            var num = 2;

            var result = logic.ReverceCharDegreeOfNumber(word, num);

            Assert.Equal("������", result);
        }
        [Fact]
        public void ReverceCharDegreeOfNumber_ThreeChar()
        {
            var word = "������";
            var num = 3;

            var result = logic.ReverceCharDegreeOfNumber(word, num);

            Assert.Equal("������", result);
        }
        [Fact]
        public void SpecifiesHowManyVowels_ToLower()
        {
            var st = "������ ���";
            var num = 3;

            var result = logic.SpecifiesHowManyVowels(st);

            Assert.Equal(result, num);
        }
        [Fact]
        public void SpecifiesHowManyVowels_ToUpper()
        {
            var st = "������ ��� ������";
            var num = 7;

            var result = logic.SpecifiesHowManyVowels(st);

            Assert.Equal(result, num);
        }
    }
}