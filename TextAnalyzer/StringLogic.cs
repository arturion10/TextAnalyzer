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
    }
}
