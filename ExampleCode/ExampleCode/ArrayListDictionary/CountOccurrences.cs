using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode.ArrayListDictionary
{
    internal class CountOccurrences
    {
        public int CountOccurrence(string inputSentence, string word)
        {
            int count = 0;
            int index  = 0;

            while ((index = inputSentence.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index = index + word.Length;
            }
            return count;
        }
    }
}
