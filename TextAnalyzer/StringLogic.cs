using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    public class StringLogic
    {
        public string ReverceString(string word)
        {
            var arr = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                arr[i] = word[word.Length - 1 - i];
            }
            return string.Join("", arr);
        }

        public bool IsReverseString(string word)
        {
            var arr = word.ToLower().ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                arr[i] = word.ToLower()[word.Length - 1 - i];
            }

            var total = string.Join("", arr) == word.ToLower();

            return total;
        }

        public string ReverceCharDegreeOfNumber(string word, int num)
        {
            var arr = word.ToCharArray();
            var length = arr.Length;
            for (int i = 1; i * num < arr.Length; i *= num)
            {
                char a = arr[i - 1];
                char b = arr[i * num - 1];
                arr[i - 1] = b;
                arr[i * num - 1] = a;
            }
            return string.Join("", arr);
        }

        public int SpecifiesHowManyVowels(string st)
        {
            var conVowel = 0;
            for (var i = 0; i < st.Length; i++)
            {
                switch (st.ToLower()[i])
                {
                    case 'а':
                        conVowel++;
                        break;
                    case 'о':
                        conVowel++;
                        break;
                    case 'э':
                        conVowel++;
                        break;
                    case 'е':
                        conVowel++;
                        break;
                    case 'и':
                        conVowel++;
                        break;
                    case 'ы':
                        conVowel++;
                        break;
                    case 'у':
                        conVowel++;
                        break;
                    case 'ё':
                        conVowel++;
                        break;
                    case 'ю':
                        conVowel++;
                        break;
                    case 'я':
                        conVowel++;
                        break;
                }
            }
            return conVowel;
        }
    }
}
