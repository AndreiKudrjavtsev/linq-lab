using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static linq.Task4;
using static linq.Task5;
using static linq.Task6;
using static linq.Task7;

namespace linq
{
    internal class Program
    {
        private static IEnumerable<CTestEntity> testData = CreateTestCollection();
        private static String sentence = "Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена";
        private static String toBook = "This dog eats too much vegetables after lunch";

        public static void Main(string[] args)
        {
            
            PrintCollection(testData);

            // Test for 4th task
            Console.WriteLine("Testing 4th task: ");
            Console.WriteLine(ConcatExceptFirstThree(testData, '/') + '\n');
            
            // Test for 5tn task
            Console.WriteLine("Testing 5th task: ");
            PrintCollection(SelectNameGreaterThanPosition(testData));

            // Test for 6th task
            Console.WriteLine('\n' + "Testing 6th task: ");
            Console.WriteLine(sentence);
            var result = GroupSentence(sentence);
            foreach (var group in result)
            {
                Console.WriteLine($"Длина слов в группе: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }

            // Test for 7th task
            Console.WriteLine('\n' + "Testing 7th task: ");
            Console.WriteLine(toBook);
            Console.WriteLine($"Translation: \n{TranslateToBook(toBook, 3)}");
        }

        private static void PrintCollection(IEnumerable<CTestEntity> data)
        {
            foreach (var entry in data)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
        }

        private static IEnumerable<CTestEntity> CreateTestCollection()
        {
            var entry1 = new CTestEntity("Robert");
            var entry2 = new CTestEntity("Chris");
            var entry3 = new CTestEntity("Jessica");
            var entry4 = new CTestEntity("Ana");
            var entry5 = new CTestEntity("John");
            return new List<CTestEntity>() { entry1, entry2, entry3, entry4, entry5 };
        }
    }
}
