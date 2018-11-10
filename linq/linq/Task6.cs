using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal static class Task6
    {
        public static IEnumerable<IGrouping<Int32, String>> GroupSentence(String sentence)
        {
            var punctuation = sentence.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = sentence.Split().Select(x => x.Trim(punctuation)).Where(x => x.Length > 0);

            return words.GroupBy(w => w.Length).OrderBy(x => x.Key);
        }
    }
}
