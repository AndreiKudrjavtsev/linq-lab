using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal static class Task7
    {
        public static String TranslateToBook(String text, int wordsOnPage)
        {
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation).ToLower()).Where(x => x.Length > 0);
            var translated = words.Select(w => dictionary[w].ToUpper());
            var pages = translated.Select((word, index) => new { word, index })
                .GroupBy(w => w.index / wordsOnPage)
                .Select(g => g.Select(a => a.word));

            var result = pages.Select(page => page.Aggregate((word1, word2) => word1 + " " + word2));

            return result.Select((page, index) => $"{page} // страница {index + 1} \n")
                .Aggregate((p1, p2) => p1 + p2);
        }

        private static Dictionary<String, String> dictionary = new Dictionary<string, string>()
        {
            { "this", "эта" },
            { "dog", "собака" },
            { "eats", "ест" },
            { "too", "слишком" },
            { "much", "много" },
            { "vegetables", "овощей" },
            { "after", "после" },
            { "lunch", "обеда" },
            { "some", "несколько" },
            { "other", "других" },
            { "test", "тестовых" },
            { "words", "слов" },
            { "just", "просто" },
            { "in", "на" },
            { "case", "случай" }
        };
    }
}
